﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesMac.Models
{
    public class Lanche
    {
        public int LancheId { get; set; }
        public int CategoriaId { get; set; }
        [StringLength(100)]
        public string DescricaoCurta { get; set; }
        [StringLength(255)]
        public string DescricaoDetalhada { get; set; }
        public bool EmEstoque { get; set; }
        
        [StringLength(200)]
        public string ImagemThumbnailUrl { get; set; }
        [StringLength(200)]
        public string ImagemUrl { get; set; }
        public bool IsLanchePreferido { get; set; }
        [StringLength(100)]
        public string Nome { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Preco { get; set; }
        public virtual Categoria Categoria {  get;}
    }
}
