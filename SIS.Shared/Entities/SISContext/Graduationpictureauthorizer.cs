using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Graduationpictureauthorizer
    {
        public int Graduationpictureauthorizerid { get; set; }
        public string Staffid { get; set; }
        public int Departmentid { get; set; }
        public int Graduationpictureauthorizertypeid { get; set; }
        public bool? Isactive { get; set; }

        public virtual Graduationpictureauthorizertype Graduationpictureauthorizertype { get; set; }
    }
}
