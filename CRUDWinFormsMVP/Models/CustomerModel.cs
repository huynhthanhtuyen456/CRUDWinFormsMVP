using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using ElectricCalculator.Enums;

namespace CRUDWinFormsMVP.Models
{
    public class CustomerModel
    {
        //Fields
        private int id;
        private string name;
        private DateTime dateOfBirth;
        private int gender;
        private int occupation;

        //Properties - Validations
        [DisplayName("Customer ID")]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        [DisplayName("Customer Name")]
        [Required(ErrorMessage = "Customer name is requerid")]
        [StringLength(50,MinimumLength =3, ErrorMessage = "Customer name must be between 3 and 50 characters")]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        [DisplayName("Customer DateOfBirth")]
        [Required(ErrorMessage = "Customer DateOfBirth is requerid")]
        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }

        [DisplayName("Customer Gender")]
        [Required(ErrorMessage = "Pet Gender is requerid")]
        public int Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        [DisplayName("Customer Occupation")]
        [Required(ErrorMessage = "Customer Occupation is requerid")]
        public int Occupation
        {
            get { return occupation; }
            set { occupation = value; }
        }

        public string GenderText()
        {
            GenderEnum genderVal = (GenderEnum)this.Gender;
            string genderText = genderVal.ToString();
            return genderText;
        }

        public string OccupationText()
        {
            OccupationEnum occupationVal = (OccupationEnum)this.Occupation;
            string occupationText = occupationVal.ToString();
            return occupationText;
        }
    }
}
