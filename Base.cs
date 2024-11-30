using ClassePessoa;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Users;

namespace baze
{
    public class Base : ITransportes
    {
        public string Marca;
        public string Cor;
        public string Velocidade;
        

        public void Idade()
        {
            int age = 0;
        }

        public List<Base> Ler()
        {
            var ver = new List<Base>();
            if (!File.Exists(Diretorio()))
            {
                File.Create(Diretorio());
                StreamReader streamReader = File.OpenText(Diretorio());

                string linha;
                Console.WriteLine("=====================" + this.GetType().Name + "=====================");
                while ((linha = streamReader.ReadLine()) != null)
                {
                    var arkivo = linha.Split(';');
                    var arquivo = new Base();
                    arquivo.Marca = arkivo[0];
                    arquivo.Cor = arkivo[1];
                    arquivo.Velocidade = arkivo[2];
                    ver.Add(arquivo);
                    Console.WriteLine(arquivo.Marca + "\t" + arquivo.Cor + "\t" + arquivo.Velocidade);
                    // var ver = (ITransportes)Activator.CreateInstance(typeof(ITransportes));

                }
                StreamReader streamReader = File.OpenText(Diretorio());
            
            string linha;
            Console.WriteLine("=====================" + this.GetType().Name + "=====================");
            while ((linha = streamReader.ReadLine()) != null)
            {
                var arkivo = linha.Split(';');
                var arquivo = new Base();
                arquivo.Marca = arkivo[0];
                arquivo.Cor = arkivo[1];
                arquivo.Velocidade = arkivo[2];
                ver.Add(arquivo);
                Console.WriteLine(arquivo.Marca + "\t" + arquivo.Cor + "\t" + arquivo.Velocidade);
               // var ver = (ITransportes)Activator.CreateInstance(typeof(ITransportes));
            }
            streamReader.Close();
            return ver;
        }
        private string Diretorio()
        {
            return ConfigurationManager.AppSettings["Diretorio"] + this.GetType().Name + ".txt";
           
        }

        public void Registar()
        {
            
            string actual = this.Marca + "; " + this.Cor + ";" + ";";
           
                StreamWriter writer = File.AppendText(Diretorio());
                writer.WriteLine(this.Marca + "; " + this.Cor + "; " + this.Velocidade + "; ");
                writer.Close();

           

        }
        }
}
