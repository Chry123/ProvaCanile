using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace canile.Data
{
    public class Cane
    {

       // MEGLIO NON FARE I CONSTRAICT

        
        /// <summary>
        /// l'ID del cane
        /// </summary>
        [Required(ErrorMessage = " Inserire l' ID" )]
        public int ID { get; set; }

        /// <summary>
        /// Convalida del nome
        /// </summary>
        [Required(ErrorMessage = " Inserire il nome")]
        [StringLength(10, MinimumLength =1, ErrorMessage ="Il nome del cane deve avere una lunghezza minima di 1 e un massmo di 10!" )]
        public string Nome { get; set; }

        /// <summary>
        /// Convalida per l' eta del cane
        /// </summary>
        [Required(ErrorMessage = " Inserire l' eta")]
        public byte Eta { get; set; }

        /// <summary>
        /// Convalida per l' adozione del cane
        /// </summary>
        [Required(ErrorMessage = " Inserire la adozione")]
        public DateTime Adozione { get; set; }

        /// <summary>
        /// convalida per la razza
        /// </summary>
        [Required(ErrorMessage = " Inserire la razza")]
        [StringLength(20, MinimumLength = 1, ErrorMessage = "Il nome del cane deve avere una lunghezza minima di 1 e un massmo di 20!")]
        public string Razza { get; set; }

        /// <summary>
        /// convalida per il genere
        /// </summary>
        [Required(ErrorMessage = " Inserire il genere")]
        public bool Maschio { get; set; }

        /// <summary>
        /// convalida per l'aquisizione
        /// </summary>
        [Required(ErrorMessage = " Inserire la aquisizione")]
        public DateTime Aquisizione { get; set; }

        /// <summary>
        /// convalida per la sterilizzazione
        /// </summary>
        [Required(ErrorMessage = " Inserire la sterilizazzione")]
        public bool Sterilizzazione { get; set; }
        
    }
}
