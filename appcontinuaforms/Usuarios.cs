using System;

class Usuarios : Personas
{
    public string id_usuario { get; set; }
    public string contraseña { get; set; }
    public string dependencia { get; set; }
    public string email_admin { get; set; }
    public string nombre_admin { get; set; }


    //constructor 
    private  Usuarios(string id_us,string pass, string dependencia, string eadmin, string admin, string nom, string ape, string tel, string direc, string ema, string cel, string ep, string tipo) : base(nom, ape, tel, direc, ema, cel, ep, tipo)
    {
        this.id_usuario = id_us;
        this.contraseña = pass;
        this.dependencia = dependencia;
        this.email_admin = eadmin;
        this.nombre_admin = admin; 
    }

}
