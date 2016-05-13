using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS_5.Forms
{
    public static class GlobalVar
{
    /// <summary>
    /// Global variable that is constant.
    /// </summary>
    //public const string GlobalString = TelaInicial.NomeUsuario;


    static int _globalValue;


         public static int GlobalValue
          {
	            get
	      {
	            return _globalValue;
	      }
	            set
	      {
	     _globalValue = value;
	      }
          }      

        public static bool GlobalBoolean;
          }

          }
