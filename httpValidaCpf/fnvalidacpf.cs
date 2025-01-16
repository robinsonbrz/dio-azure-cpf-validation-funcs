using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace httpValidCPF
{
    public class fnvalidacpf
    {
        private readonly ILogger<fnvalidacpf> _logger;

        public fnvalidacpf(ILogger<fnvalidacpf> logger)
        {
            _logger = logger;
        }

        [Function("fnvalidacpf")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("Iniciando a validação do CPF.");

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            using var jsonDoc = JsonDocument.Parse(requestBody);
            JsonElement root = jsonDoc.RootElement;

            if (!root.TryGetProperty("cpf", out JsonElement cpfElement) || string.IsNullOrEmpty(cpfElement.GetString()))
            {
                return new BadRequestObjectResult("Por favor, informe um CPF válido.");
            }

            string cpf = cpfElement.GetString();

            // Valida o CPF
            if (!ValidaFormatoCPF(cpf))
            {
                return new BadRequestObjectResult("O CPF deve estar no formato xxx.xxx.xxx-xx.");
            }

            bool isValid = ValidaCPF(cpf);

            if (!isValid)
            {
                return new BadRequestObjectResult("O CPF informado é inválido.");
            }

            return new OkObjectResult($"O CPF {cpf} é válido.");
        }

        // Método para validar o formato do CPF
        public static bool ValidaFormatoCPF(string cpf)
        {
            // Verifica se o CPF está no formato xxx.xxx.xxx-xx
            return Regex.IsMatch(cpf, @"^\d{3}\.\d{3}\.\d{3}-\d{2}$");
        }

        // Método para validação de CPF
        public static bool ValidaCPF(string cpf)
        {
            // Remove os caracteres de formatação (pontos e hífen)
            cpf = Regex.Replace(cpf, @"[^\d]", "");

            if (cpf.Length != 11 || Regex.IsMatch(cpf, @"^(\d)\1{10}$"))
            {
                return false; // Verifica tamanho e CPFs com todos os números iguais
            }

            int[] multiplicador1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            string tempCpf = cpf.Substring(0, 9);
            int soma = 0;

            for (int i = 0; i < 9; i++)
            {
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            }

            int resto = soma % 11;
            int digito1 = resto < 2 ? 0 : 11 - resto;

            tempCpf += digito1;
            soma = 0;

            for (int i = 0; i < 10; i++)
            {
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            }

            resto = soma % 11;
            int digito2 = resto < 2 ? 0 : 11 - resto;

            return cpf.EndsWith($"{digito1}{digito2}");
        }
    }
}
