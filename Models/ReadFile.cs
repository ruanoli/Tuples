namespace Tuplas.Models
{
    public class ReadFile
    {
        //Método Tupla. Retornando três tipos diferentes de dados.
        //criou ou não,conteúdo das linhas, quantidade de linhas

        //Se não tiver nenhum erro, terá sucesso, serão criadas as linhas
        //e a saberemos a quantidade de linhas.

        //Se ocorrer algum erro o sucesso será false, lines um array de string vazio
        //e 0 quantidades de linhas.
        public (bool Sucess, string[] Lines, int QuantityLines) ReadingFile(string way)
        {
            try
            {
	            string[] lines = File.ReadAllLines(way);
	
	            return (true, lines, lines.Count());
            }
            catch (Exception ex)
            {
                return (false, new string[0], 0);
            }
        }
    }
}