using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bil203_Otopark_FinalProject.Data
{
    public class AraclarModel
    {
        [Key]
        public int Id { get; set; }
        public string marka { get; set; }
        public string model { get; set; }
        public string plaka { get; set; }
        public DateTime girTar { get; set; }
        public DateTime? cikTar { get; set; }
        public int icerdemi { get; set; }
        public string para { get; set; }

        public AraclarModel(int Id, string marka, string model, string plaka, DateTime girTar,
           DateTime? cikTar, int icerdemi)
        {
            this.Id = Id;
            this.marka = marka;
            this.model = model;
            this.plaka = plaka;
            this.girTar = girTar;
            this.cikTar = cikTar;
            this.icerdemi = icerdemi;
        }

        public AraclarModel()
        {

        }
    }
}
