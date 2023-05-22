namespace DesafioAluno
{
    public class Aluno
    {
        private int _matricula;
        public int Matricula
        {
            get { return _matricula; }
            set
            {
                if (value <= 0)
                    Console.WriteLine("O valor da matrícula não pode ser menor ou igual a zero!");
                else
                    _matricula = value;
            }
        }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public bool Status { get; set; }
        public int TipoCurso { get; set; }
    }
}
