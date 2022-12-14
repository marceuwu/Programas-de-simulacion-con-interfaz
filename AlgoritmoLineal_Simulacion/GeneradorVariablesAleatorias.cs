using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.Distributions;
using MathNet.Numerics.Statistics;

namespace AlgoritmoLineal_Simulacion
{
    public class GeneradorVariablesAleatorias
    {
        int n;
        int cont;
        float t;
        float tPrima;
        List<float> PSE;
        List<float> varGenerados;
        float media;
        float desv;
        float varianza;
        public string cadena = "";
        public string cadenaVar = "";
        public GeneradorVariablesAleatorias()
        {
            cont = 0;
            n = 0;
            t = 1;
            media = 10;
            varianza =(float) 42.35;
            desv = (float)Math.Sqrt(varianza);
            NumPseudoaleatorios oNumeros = new NumPseudoaleatorios(6, 8192, 15, 13);
            PSE = oNumeros.getNumerosPseudoaleatrios();
            varGenerados = new List<float>();
        }
        public void PruebaChiCuadradaPoisson()
        {
            cadena = "";
            float menor = (float)varGenerados.Min();
            float mayor = (float)varGenerados.Max();
            float media = (float)Statistics.Mean(varGenerados);
            float desvEstandar = (float)Statistics.StandardDeviation(varGenerados);
            float  varianza = (float)Statistics.Variance(varGenerados);
            float n = varGenerados.Count();
            float m = (float)Math.Ceiling(Math.Sqrt(n));
            float rango = mayor - menor;
            float anchoClase = rango / m;
            anchoClase = (float)Math.Ceiling(anchoClase);
            media = (float)Math.Round(media, 0);
            desvEstandar = (float)Math.Round(desvEstandar, 2);
            m = (float)Math.Ceiling(m);
            cadena = cadena + "\n\nPrueba de Chi Cuadrada para Poisson:\n\n";
            cadena = cadena + "\n---------------- DATOS ----------------";
            cadena = cadena + "\nMenor: " + menor;
            cadena = cadena + "\nMayor: " + mayor;
            cadena = cadena + "\nMedia: " + media;
            cadena = cadena + "\nDesviacion Estandar: " + desvEstandar;
            cadena = cadena + "\nVarianza: " + varianza;
            cadena = cadena + "\nNumero de variables: " + n;
            cadena = cadena + "\nNumero de clases: " + m;
            cadena = cadena + "\nRango: " + rango;
            cadena = cadena + "\nAncho de clase: " + anchoClase;
            cadena = cadena + "\nIntervalos: " + m;
            cadena = cadena + "\n---------------------------------------";
            cadena = cadena + "\nIntervalo \tOi \tx \tp(x) \t\tEi \tError";
            cadena = cadena + "\n-------------------------------------------------------------------------------------------------";

            Console.WriteLine("\n\nPrueba de Chi Cuadrada para Poisson:\n\n");
            Console.WriteLine("---------------- DATOS ----------------");
            Console.WriteLine("Menor: " + menor);
            Console.WriteLine("Mayor: " + mayor);
            Console.WriteLine("Media: " + media);
            Console.WriteLine("Desviacion Estandar: " + desvEstandar);
            Console.WriteLine("Varianza: " + varianza);
            Console.WriteLine("Numero de variables: " + n);
            Console.WriteLine("Numero de clases: " + m);
            Console.WriteLine("Rango: " + rango);
            Console.WriteLine("Ancho de clase: " + anchoClase);
            Console.WriteLine("Intervalos: " + m);
            Console.WriteLine("---------------------------------------");
            //Generar Intervalos
            Console.WriteLine("\nIntervalo \tOi \tx \tp(x) \t\tEi \tError");
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            int inter = 0;
            float frecuenciaObservada = 0;
            float limiteInferior = 0;
            float limiteSuperior = 0;
            float x, px, ei, error, sumaProb = 0;
            float pxAnterior = 0;
            float chiCalculado = 0;
            //Usamos como parametro los grados de libertad, que es igual a la cantidad de intervalos - 1 - el numero de parametros
            var CHI = new ChiSquared(m-1);
            //Usamos como parametro el nivel de confianza
            float chiTabla = (float)CHI.InverseCumulativeDistribution(0.95);

            //Usamos como parametro lambda, que es igual a la media
            var POISSON = new Poisson(media);

            while (inter < m)
            {
                frecuenciaObservada = 0;
                limiteInferior = (float)(0 + (inter * anchoClase));
                if (inter == m - 1)
                {
                    limiteSuperior = 1000;
                }
                else
                {
                    limiteSuperior = (float)(limiteInferior + anchoClase);
                }
                frecuenciaObservada = frecuenciaObservada + isBetween(limiteInferior, limiteSuperior);
                if (inter == m - 1)
                {
                    x = 0;
                    px = 1 - sumaProb;
                    sumaProb = sumaProb + px;
                    ei = n * px;
                    error = (float)Math.Pow((ei - frecuenciaObservada), 2) / ei;
                    chiCalculado = chiCalculado + error;
                    cadena = cadena + "\n" + Math.Round(limiteInferior, 2) + "," + Math.Round(limiteSuperior, 2) + "\t" + frecuenciaObservada + " \t" + x + " \t" + Math.Round(px, 5) + " \t\t" + Math.Round(ei, 2) + " \t" + Math.Round(error, 2);
                    Console.WriteLine("[" + Math.Round(limiteInferior, 2) + "," + Math.Round(limiteSuperior, 2) + "  ] \t" + frecuenciaObservada + " \t" + x + " \t" + Math.Round(px, 5) + "\t\t" + Math.Round(ei, 2) + " \t" + Math.Round(error, 2));
                }
                else
                {
                    x = limiteSuperior;
                    px = (float)POISSON.CumulativeDistribution(x);
                    px = px - pxAnterior;
                    pxAnterior = pxAnterior + px;
                    sumaProb = sumaProb + px;
                    ei = n * px;
                    error = (float)Math.Pow((ei - frecuenciaObservada), 2) / ei;
                    chiCalculado = chiCalculado + error;
                    cadena = cadena +"\n"+ Math.Round(limiteInferior, 2) + " - " + Math.Round(limiteSuperior, 2) + " \t" + frecuenciaObservada + " \t" + x + " \t" + Math.Round(px, 5) + " \t\t" + Math.Round(ei, 2) + " \t" + Math.Round(error, 2);
                    Console.WriteLine( Math.Round(limiteInferior, 2) + " - " + Math.Round(limiteSuperior, 2) + " \t" + frecuenciaObservada + " \t" + x + " \t" + Math.Round(px, 5) + "  \t" + Math.Round(ei, 2) + " \t" + Math.Round(error, 2));
                }
                inter++;
            }

            cadena = cadena + "\n-------------------------------------------------------------------------------------------------";
            cadena = cadena + "\nChi Calculado: " + Math.Round(chiCalculado, 2);
            cadena = cadena + "\nChi Tabla: " + chiTabla;
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            Console.WriteLine("Chi Calculado: " + Math.Round(chiCalculado, 2));
            Console.WriteLine("Chi Tabla: " + chiTabla);
            if (chiCalculado < chiTabla)
            {
                cadena = cadena + "\nSe ha pasado la prueba";
                Console.WriteLine("Se ha pasado la prueba");
            }
            else
            {
                cadena = cadena + "\nNo se ha pasado la prueba";
                Console.WriteLine("No se ha pasado la prueba");
            }

        }
        public float EcuacionRecursivaPoisson(float landa)
        {
            n = 0;
            t = 1;
            float e = (float)Math.Exp(-landa);
            for(; ; )
            {
                tPrima = t * PSE[cont];
                cont++;
                if(tPrima >= e)
                {
                    n++;
                    t = tPrima;
                }
                else
                {
                    //Console.WriteLine(n);
                    return n;
                }
            }

            return 0;
        }

        public float EcuacionRecursivaNormal()
        {
            float N = 0;
            for (int j=0; j<12; j++)
            {
                N = N + PSE[cont];
                cont++;     
            }
            N = N - 6;
            N = N * desv + media;
            if (N <= 0)
            {
                return EcuacionRecursivaNormal();
            }
            return N;
        }
        public float ObtenerDatoMenor()
        {
            float menor = varGenerados[0];
            foreach (var num in varGenerados)
            {
                if(num < menor)
                {
                    menor = num;
                }
            }
            return menor;
        }
        public float ObtenerDatoMayor()
        {
            float mayor = varGenerados[0];
            foreach (var num in varGenerados)
            {
                if (num > mayor)
                {
                    mayor = num;
                }
            }
            return mayor;
        }
        public double F(double x)
        {
            MathNet.Numerics.Distributions.Normal result = new MathNet.Numerics.Distributions.Normal();
            return result.CumulativeDistribution(x);
        }
        public double ChiCuadrada(int parametros, int gradosLib)
        {
            var chi = new ChiSquared(gradosLib-parametros-1);
            return chi.InverseCumulativeDistribution(0.95);
        }
        public void TablaFrecuencia()
        {
            cadena = "";
            float menor = this.ObtenerDatoMenor();
            float mayor = this.ObtenerDatoMayor();
            float rango = mayor - menor;
            int frecuencia;
            int cantDatos = varGenerados.Count;
            int contInt = 1;
            float z;
            float x;
            float pZactual = 0;
            float pZanterior = 0;
            float pX = 0;
            float Ei;
            float error;
            float suma = 0;
            float sumaError = 0;
            //int intervalos = (int)Math.Round(1 + 3.322 * Math.Log(varGenerados.Count));
            int intervalos = (int)Math.Sqrt(cantDatos);
            float amplitud = (float)Math.Round(rango / intervalos, 2);

            float limInf = 0;
            float limSup = 0;

            media = (float)Statistics.Mean(varGenerados);
            desv = (float)Statistics.StandardDeviation(varGenerados);
            varianza = (float)Statistics.Variance(varGenerados);
            cadena += "\n---------------- DATOS ----------------";
            cadena += "\nMedia: " + media;
            cadena += "\nDesviacion estandar: " + desv;
            cadena += "\nMin: " + menor;
            cadena += "\nMax: " + mayor;
            cadena += "\nRango: " + rango;
            cadena += "\nAmplitud: " + amplitud;
            cadena += "\nInervalos: " + intervalos;
            cadena += "\n---------------------------------------";
            cadena += "\n\nnum"+"\t\t"+"Intervalo\t Oi\t x\t z\t p(z)\t p(x)\t Ei\tError";
            cadena += "\n-------------------------------------------------------------------------------------------------------------------";
            Console.WriteLine("---------------- DATOS ----------------");
            Console.WriteLine("Media: " + media);
            Console.WriteLine("Desviacion estandar: " + desv);
            Console.WriteLine("Min: " + menor);
            Console.WriteLine("Max: " + mayor);
            Console.WriteLine("Rango: " + rango);
            Console.WriteLine("Amplitud: " + amplitud);
            Console.WriteLine("Intervalos: " + intervalos);
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("\n\nnum\tIntervalo\t Oi\t x\t z\t p(z)\t p(x)\t Ei\tError");
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            do
            {
                
                limSup = (float)Math.Round(limInf + amplitud, 2);
                frecuencia = isBetween(limInf, limSup);
                x = limSup;
                z = (float)Math.Round((x - media) / desv, 2);
                pZactual = (float)Math.Round(this.F(z),2); 
                pX = (float)Math.Round(pZactual-pZanterior,2);
                pZanterior = pZactual;
                Ei = cantDatos * pX;
                error = (float)Math.Pow((Ei - frecuencia), 2) / Ei;
                cadena+="\n"+contInt + "\t" + limInf + " - " + limSup + "\t" + frecuencia + "\t" + x + "\t" + z + "\t" + pZactual + "\t" + pX + "\t" + Ei + "\t" + error;
                Console.WriteLine(contInt + "\t" + limInf + " - " + limSup + "\t" + frecuencia + "\t" + x + "\t" + z + "\t" + pZactual + "\t" + pX + "\t" + Ei + "\t" + error);
                limInf = limSup;
                suma += pX;
                contInt++;
                sumaError += error;
                
            } while (intervalos>contInt);
            pX = (float)Math.Round(1 - suma,2);
            Ei = cantDatos * pX;
            error = (float)Math.Pow((Ei - frecuencia), 2) / Ei;
            sumaError += error;
            cadena+="\n"+contInt + "\t" + limInf + " - " + limSup + "\t" + frecuencia + "\t" + x + "\t" + z + "\t" + pZactual + "\t" + pX + "\t" + Ei + "\t" + error;
            cadena+="\n-------------------------------------------------------------------------------------------------------------------";
            Console.WriteLine(contInt + "\t" + limInf + " - " + limSup + "\t" + frecuencia + "\t" + x + "\t" + z + "\t" + pZactual + "\t" + pX + "\t" + Ei + "\t" + error);
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            double chiCalculada = sumaError;
            double chiTabla = ChiCuadrada(2, intervalos);
            cadena+="\nCHI CALCULADO: "+chiCalculada;
            cadena+="\nCHI TABLA: " + chiTabla+"\n";
            Console.WriteLine("\nCHI CALCULADO: " + chiCalculada);
            Console.WriteLine("CHI TABLA: " + chiTabla + "\n");

            if (chiCalculada < chiTabla)
            {
                cadena+="\nno podemos rechazar la hipótesis de que la variable \r\naleatoria se comporta de acuerdo con una distribución de Normal :)";
                Console.WriteLine("no podemos rechazar la hipótesis de que la variable \r\naleatoria se comporta de acuerdo con una distribución de Normal :)");
            }
            else
            {
                cadena+="\nrechazamos la hipótesis de que la variable \r\naleatoria se comporta de acuerdo con una distribución de Normal :(";
                Console.WriteLine("rechazamos la hipótesis de que la variable \r\naleatoria se comporta de acuerdo con una distribución de Normal :(");
            }


        }
        public void GeneradorVariablesNormal(int Corridas)
        {
            cadenaVar = "";
            float num=0;
            for(int i = 0; i < Corridas; i++)
            {
                num = this.EcuacionRecursivaNormal();
                varGenerados.Add(num);
                Console.WriteLine(num);
                cadenaVar += "\n" + num;
            }
        }
        public void GeneradorVariablesPoisson(float landa, int corridas)
        {
            cadenaVar = "";
            float num = 0;
            for (int i = 0; i < corridas; i++)
            {
                num = EcuacionRecursivaPoisson(landa);
                varGenerados.Add(num);
                Console.WriteLine(num);
                cadenaVar += "\n" + num;
            }
        }
        public int isBetween(float inf, float sup)
        {
            int i = 0;
            foreach(var num in varGenerados)
            {
                if (num >= inf && num < sup)
                {
                    i++;
                }
            }
            
            return i++;
        }
        public void MetodoChiCuadrada()
        {
            foreach(var num in varGenerados)
            {
                
            }
        }
    }
}
