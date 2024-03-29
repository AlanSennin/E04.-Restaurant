﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comanda
{
    public class BaseDatos
    {
        public List<Menu> listamenu { get; private set; }
        public List<Aperitivo> ListAperitivos { get; private set; }
        public List<Ensaladas> ListEnsalada { get; private set; }
        
        public List<Carnes> ListCarnes { get; private set; }
        public List<Pescado> ListPescado { get; private set; }
        public List<Pollo> ListPollo { get; private set; }
        public List<Pastas> ListPasta { get; private set; }
        public List<Sandwichs> ListSandwich { get; private set; }
        public List<Paninis> ListPaninis { get; private set; }
        public List<Postres> ListPostre { get; private set; }
        public List<Bebidas> ListBebida { get; private set; }
        public List<Empty> Vacio { get; private set; }

        public BaseDatos()
        {
            listamenu = new List<Menu>();
            ConstruirMenu();
        }

        private void ConstruirMenu()
        {
            listamenu = new List<Menu>
            {   new Menu{Id=0,Nombre="None"},
                new Menu {Id = 1, Nombre = "Aperitivos"},
                new Menu {Id = 2, Nombre = "Ensalada"},
                new Menu {Id = 3, Nombre = "Carne"},
                new Menu {Id = 4, Nombre = "Pescado"},
                new Menu {Id = 5, Nombre = "Pollo"},
                new Menu {Id = 6, Nombre = "Pasta"},
                new Menu {Id = 7, Nombre = "Sandwichs"},
                new Menu {Id = 8, Nombre = "Paninis"},
                new Menu {Id = 9, Nombre = "Postre"},
                new Menu {Id = 10, Nombre = "Bebidas"}                          
            };

            ListEnsalada = new List<Ensaladas> 
            {
             new Ensaladas{Id=0,Nombre="None"},
             new Ensaladas{Id=1,Nombre="Primavera"},
             new Ensaladas{Id=2,Nombre="Clasica"},
             new Ensaladas{Id=3,Nombre="Delizioso"},
             new Ensaladas{Id=4,Nombre="Caesar con Pollo"},
             new Ensaladas{Id=5,Nombre="Rustica con Camaron"},
             new Ensaladas{Id=6,Nombre="Caprese"}
            
            };

            ListAperitivos = new List<Aperitivo>
            {
                new Aperitivo {Id =0 , Nombre = "None"},
                new Aperitivo {Id =1 , Nombre = "Calamar frito"}, 
                new Aperitivo {Id =2 , Nombre = "Plato siciliano"}, 
                new Aperitivo {Id =3 , Nombre = "Antipasti delizioso"},
                new Aperitivo {Id =4 , Nombre = "Fonduta Ahumada"},
                new Aperitivo {Id =5 , Nombre = "Mini albondigas delizioso"},
                new Aperitivo {Id =6 , Nombre = "Zuppa"},
                new Aperitivo {Id =7 , Nombre = "Crostini delizioso"},
                new Aperitivo {Id =8 , Nombre = "Champinones rellenos"},
            };

            ListCarnes = new List<Carnes>
            {   new Carnes {Id =0,   Nombre="None"},
                new Carnes {Id =1 , Nombre = "Filete de la casa"},
                new Carnes {Id =2 , Nombre = "Filete Mignon"},
                new Carnes {Id =3 , Nombre = "Milanesa de Res Rellena"}
            };

            ListPescado = new List<Pescado>
            {
                new Pescado {Id =0,  Nombre = "None"},
                new Pescado {Id =1 , Nombre = "Salmon"},
                new Pescado {Id =2 , Nombre = "Risoto con camaron"},
                new Pescado {Id =3 , Nombre = "Mar Delizioso"},
                new Pescado {Id =4 , Nombre = "Tilapia parmesana"},
                new Pescado {Id =5 , Nombre = "Croquetas de cangrejo"},
                new Pescado {Id =6 , Nombre = "Ceviche"}
            };

            ListPollo = new List<Pollo>
            {
                new Pollo {Id =0 , Nombre = "None"},
                new Pollo {Id =1 , Nombre = "Marsala"},
                new Pollo {Id =2 , Nombre = "Rostizado en hierbas"},
                new Pollo {Id =3 , Nombre = "Parmigiana"},
                new Pollo {Id =4 , Nombre = "Picatta"},
                new Pollo {Id =5 , Nombre = "Pechuga de pollo rellena"},
            };
            ListPasta = new List<Pastas>
            {
                new Pastas {Id =0 ,  Nombre = "None"},
                new Pastas {Id =1 ,  Nombre = "Spaguetti a la putanesca"},
                new Pastas {Id =2 ,  Nombre = "Spaguetti clasico"},
                new Pastas {Id =3 ,  Nombre = "Pasta bolognesa"},
                new Pastas {Id =4 ,  Nombre = "Pasta al beto"},
                new Pastas {Id =5 ,  Nombre = "Delizioso pasta"},
                new Pastas {Id =6 ,  Nombre = "Pasta nana lucia"},
                new Pastas {Id =7 ,  Nombre = "Pasta pescatore"},
                new Pastas {Id =8 ,  Nombre = "Pasta al marco"},
                new Pastas {Id =9 ,  Nombre = "Pasta al roy"},
                new Pastas {Id =10 , Nombre = "Alfredo fetuccine con pollo"},
                new Pastas {Id =11 , Nombre  = "Raviolis"},
                new Pastas {Id =12 , Nombre  = "Pasta al cuore"},
                new Pastas {Id =13 , Nombre  = "Lasagna"},
                new Pastas {Id =14 , Nombre  = "Raviolis portobello"},
                new Pastas {Id =15 , Nombre  = "Rigatoni Delizioso"},
                new Pastas {Id =16 , Nombre  = "Trio delizioso"}
            };
            ListSandwich = new List<Sandwichs>
            {
                new Sandwichs {Id =0 , Nombre = "None"},
                new Sandwichs {Id =1 , Nombre = "De albondiga italiana"},
                new Sandwichs {Id =2 , Nombre = "Atun fonduta"},
                new Sandwichs {Id =3 , Nombre = "Clasico B.L.T."},
                new Sandwichs {Id =4 , Nombre = "Pavo pesto"},
                new Sandwichs {Id =5 , Nombre = "pastrami fonduta"},
                new Sandwichs {Id =6 , Nombre = "De salchicha italiana"}
            };
            ListPaninis = new List<Paninis>
            {
                new Paninis {Id =0 , Nombre = "None"},
                new Paninis {Id =1 , Nombre = "Panini de pollo"},
                new Paninis {Id =2 , Nombre = "Panini vegetariano"},
                new Paninis {Id =3 , Nombre = "Panini rosat beef"},
                new Paninis {Id =4 , Nombre = "Panini jamon"},
                new Paninis {Id =5 , Nombre = "Panini salami"},
                new Paninis {Id =6 , Nombre = "Panini pastramia"},
            };
            ListPostre = new List<Postres>
            {
                new Postres {Id =0 , Nombre = "None"},
                new Postres {Id =1 , Nombre = "Cannoli"},
                new Postres {Id =2 , Nombre = "Tirasumi"},
                new Postres {Id =3 , Nombre = "Pastel de zanaoria"},
                new Postres {Id =4 , Nombre = "Gellato"},
                new Postres {Id =5 , Nombre = "Creme brulee"},
                new Postres {Id =6 , Nombre = "Pay de queso"},
                new Postres {Id =7 , Nombre = "Brownies"},
            };
            ListBebida = new List<Bebidas>
            {
                new Bebidas {Id =0 , Nombre = "None"},
                new Bebidas {Id =1 , Nombre = "Soda"},
                new Bebidas {Id =2 , Nombre = "Agua mineral"},
                new Bebidas {Id =3 , Nombre = "Sangria preparada"},
                new Bebidas {Id =4 , Nombre = "Jugo de naranja"},
                new Bebidas {Id =5 , Nombre = "Jugo de manzana"},
                new Bebidas {Id =6 , Nombre = "Te helado"},
                new Bebidas {Id =7 , Nombre = "Limonada"},
                new Bebidas {Id =8 , Nombre = "Cafe"},
                new Bebidas {Id =9 , Nombre = "Te caliente"},
                new Bebidas {Id =10 , Nombre = "Vino"},
                new Bebidas {Id =11 , Nombre = "Cerveza"},
            };

            Vacio = new List<Empty>
            {
                new Empty {ID =0 , Nombre = "Nombre"},
              
            };

        }
        }
       }

