using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace AmigoDono.Web
{
    public class Utilidades
    {
        public static string UploadImagem(HttpPostedFileBase file)
        {
            // Upload Imagem
            string path = String.Empty;
            string pic = String.Empty;

            if (file != null)
            {
                pic = Path.GetFileName(file.FileName);
                path = Path.Combine(HttpContext.Current.Server.MapPath("~/Content/imagens"), pic);
                file.SaveAs(path);

                using (MemoryStream ms = new MemoryStream())
                {
                    file.InputStream.CopyTo(ms);
                    byte[] array = ms.GetBuffer();
                }
            }

            return pic; 
        }
    }
}