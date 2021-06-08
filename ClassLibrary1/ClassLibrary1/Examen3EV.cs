using System.Collections.Generic;

namespace Examen3EV_NS
{
    /// <summary>
    /// Esta clase nos calcula las estadísticas de un conjunto de notas 
    /// </summary>
    
    public class EstNot  
    {
        private int suspenso;  
        private int aprobado;  
        private int notable;  
        private int sobresliente;  

        private double notamedia; 

        public int Suspenso 
        {
            get => suspenso; 
            set => suspenso = value;
        }
        public int Aprobado 
        { 
            get => aprobado;
            set => aprobado = value; 
        }
        public int Notable 
        { 
            get => notable; 
            set => notable = value;
        }
        public int Sobresaliente
        { 
            get => sobresliente; 
            set => sobresliente = value; 
        }
        public double Media
        { 
            get => notamedia; 
            set => notamedia = value;
        }

        // Constructor vacío

        /// <summary>
        ///  Inicilizamos variables
        /// </summary>
        public EstNot()
        {
            Suspenso = Aprobado = Notable = Sobresaliente = 0; 
            Media = 0.0;
        }

        /// <sumary> 
        /// Constructor a partir de un array, calcula las estadísticas al crear el objeto
        /// </sumary>
        /// <param name="listnot" array que se recorrera para obter la media> /param>
        /// <returns>media</returns>

        public EstNot(List<int> listnot)
        {
            Media = 0.0;

            for (int i = 0; i < listnot.Count; i++)
            {
                if (listnot[i] < 5) Suspenso++;              // Por debajo de 5 suspenso
                else if (listnot[i] > 5 && listnot[i] < 7) Aprobado++;// Nota para aprobar: 5
                else if (listnot[i] > 7 && listnot[i] < 9) Notable++;// Nota para notable: 7
                else if (listnot[i] > 9) Sobresaliente++;         // Nota para sobresaliente: 9

                Media = Media + listnot[i];
            }

            Media = Media / listnot.Count;
        }

        /// <summary>
        /// Para un conjunto de listnot, calculamos las estadísticas
        /// calcula la notamedia y el número de suspensos/aprobados/notables/sobresalientes
        /// El método devuelve -1 si ha habido algún problema, la notamedia en caso contrario
        /// </summary>
        
        public double calcEst(List<int> listnot)
        {                                 
            Media = 0.0;

            // TODO: hay que modificar el tratamiento de errores para generar excepciones
            //
            if (listnot.Count <= 0)  // Si la lista no contiene elementos, devolvemos un error
                return -1;

            for (int i=0;i<10;i++)
                if (listnot[i] < 0 || listnot[i] > 10)      // comprobamos que las notable están entre 0 y 10 (mínimo y máximo), si no, error
                return -1;

            for (int i = 0; i < listnot.Count; i++)
            {
                if (listnot[i] < 5) Suspenso++;              // Por debajo de 5 suspenso
                else if (listnot[i] >= 5 && listnot[i] < 7) Aprobado++;// Nota para aprobar: 5
                else if (listnot[i] >= 7 && listnot[i] < 9) Notable++;// Nota para notable: 7
                else if (listnot[i] > 9) Sobresaliente++;         // Nota para sobresaliente: 9

                Media = Media + listnot[i];
            }

            Media = Media / listnot.Count;

            return Media;
        }
    }
}
