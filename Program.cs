// Calcule o tempo estimado para download de um arquivo.

double tamanhoArquivoMB;
double velocidadeConexaoMbps;
double tamanhoArquivoMb;
double tempoEstimadoMinutos;

Console.WriteLine("--- Cálculo de Tempo Estimado de Download ---\n");

// Solicitar q usuário digite o tamanho do arquivo em MB
Console.Write("Digite o tamanho do arquivo em MB:");
tamanhoArquivoMB = Convert.ToDouble(Console.ReadLine());

// Solicitar q usuário digite a velocidade da conexão em Mbps
Console.Write("Digitte a velocida da Internet em Mbps:");
velocidadeConexaoMbps = Convert.ToDouble(Console.ReadLine());

// Convertendo para megabits
tamanhoArquivoMb = tamanhoArquivoMB * 8;

// Calculando o tempo estimado em Min
tempoEstimadoMinutos = tamanhoArquivoMb / velocidadeConexaoMbps / 60;

// Exibindo o tempo estimado
Console.WriteLine($"\nO tempo estimado de download é de aproximadamente {tempoEstimadoMinutos:F2} minutos");