using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace UTTT.Ejemplo.Persona.Data.Entity
{
    public class Persona
    {
        private int id;
        private String strClaveUnica;
        private String strNombre;
        private String strAPaterno;
        private String strAMaterno;
        private int idCatSexo;
        private CatSexo catSexoTemp;
        private String strValorSexo;
        private DateTime strFnacim;
        private String strCorreoE;
        private String strCodigo;
        private String strRFC;

        [Required(ErrorMessage = "Este campo es obligatorio, porfavor selecciona uno")]
        public String StrValorSexo
        {
            get { return strValorSexo; }
            set { strValorSexo = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        [Required(ErrorMessage = "Este campo es obligatorio, porfavor selecciona uno")]
        [RegularExpression("[0-9]{1,9}([0-9]{0,2})?$",
                        ErrorMessage = "Por favor, introduce numeros")]
        [Range(typeof(Int32), "0", "1000",
       ErrorMessage = "Solo números entre 0 a 1000")]
        public String StrClaveUnica
        {
            get { return strClaveUnica; }
            set { strClaveUnica = value; }
        }

        [Required(ErrorMessage = "Este campo es obligatorio, porfavor selecciona uno")]
        [RegularExpression("^[a-zA-Z ]*$",
                        ErrorMessage = "Por favor, introduce letras")]
        [StringLength(50)]
        public String StrNombre
        {
            get { return strNombre; }
            set { strNombre = value; }
        }

        [Required(ErrorMessage = "Este campo es obligatorio, porfavor selecciona uno")]
        [RegularExpression("^[a-zA-Z ]*$",
                        ErrorMessage = "Por favor, introduce letras")]
        [StringLength(50)]
        public String StrAPaterno
        {
            get { return strAPaterno; }
            set { strAPaterno = value; }
        }

        [Required(ErrorMessage = "Este campo es obligatorio, porfavor selecciona uno")]
        [RegularExpression("^[a-zA-Z ]*$",
                        ErrorMessage = "Por favor, introduce letras")]
        [StringLength(50)]
        public String StrAMaterno
        {
            get { return strAMaterno; }
            set { strAMaterno = value; }
        }
        

        public int IdCatSexo
        {
            get { return idCatSexo; }
            set { idCatSexo = value; }
        }

        public CatSexo CatSexoTemp
        {
            get { return catSexoTemp; }
            set { catSexoTemp = value; }
        }

        [Required(ErrorMessage = "Este campo es obligatorio, porfavor selecciona uno")]
        public DateTime StrFnacim
        {
            get { return strFnacim; }
            set { strFnacim = value; }
        }

        [Required(ErrorMessage = "Este campo es obligatorio, porfavor selecciona uno")]
        [RegularExpression("\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*",
                        ErrorMessage = "Por favor, introduce una dirección de emial correcta")]
        public String StrCorreoE
        {
            get { return strCorreoE; }
            set { strCorreoE = value; }
        }

        [Required(ErrorMessage = "Este campo es obligatorio, porfavor selecciona uno")]
        [RegularExpression("^([1-9]{2}|[0-9][1-9]|[1-9][0-9])[0-9]{3}$",
                        ErrorMessage = "Por favor, introduce una codigo postal correcto")]
        public String StrCodigo
        {
            get { return strCodigo; }
            set { strCodigo = value; }
        }

        [Required(ErrorMessage = "Este campo es obligatorio, porfavor selecciona uno")]
        
        public String StrRFC
        {
            get { return strRFC; }
            set { strRFC = value; }
        }
    }
}
