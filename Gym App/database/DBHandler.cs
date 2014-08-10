using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;

namespace Gym_App.database
{
    class DBHandler
    {
        private string path;
        
        /* IDS CONSTANTES */
        private const int USER = 0;
        private const int BICEPS = 1;
        private const int TRICEPS = 2;
        private const int ESPALDA = 3;
        private const int PECHO = 4;
        private const int HOMBROS = 5;
        private const int ABS = 6;

        public DBHandler()
        {
            path = "database//dbgym.xml";
        }

        public bool login(string user, string pw)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(path);

            XmlNodeList accountNames = xmlDoc.GetElementsByTagName("accountName");
            XmlNodeList passwords = xmlDoc.GetElementsByTagName("password");

            for (int i = 0; i < accountNames.Count; i++)            
                if (accountNames[i].InnerText == user)
                    if (passwords[i].InnerText == pw)                    
                        return true;                
                
            return false;
        }

        public bool create(string user, string pw, string nombre, string apellido)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(path);

            /* Chequear existencia */
            XmlNodeList accountNames = xmlDoc.GetElementsByTagName("accountName");

            for (int i = 0; i < accountNames.Count; i++)
                if (accountNames[i].InnerText == user)
                    return false; /* Usuario repetido */

            /* Crear */
            XmlNode padre = xmlDoc.CreateNode(XmlNodeType.Element, "user", null);

            XmlNode hijoCuenta = xmlDoc.CreateElement("accountName");
            hijoCuenta.InnerText = user;

            XmlNode hijoClave = xmlDoc.CreateElement("password");
            hijoClave.InnerText = pw;

            XmlNode hijoNombre = xmlDoc.CreateElement("nombre");
            hijoNombre.InnerText = nombre;

            XmlNode hijoApellido = xmlDoc.CreateElement("apellido");
            hijoApellido.InnerText = apellido;

            XmlNode hijoFoto = xmlDoc.CreateElement("imgUrl");
            hijoFoto.InnerText = "images//blankPhoto.jpg";

            XmlNode hijoFecha = xmlDoc.CreateElement("created");
            hijoFecha.InnerText = DateTime.Now.ToString();

            XmlNode nivelsito = xmlDoc.CreateElement("nivel");
            nivelsito.InnerText = "0";

            XmlNode exp = xmlDoc.CreateElement("exp");
            exp.InnerText = "0";

            /* Crear Rutinas */
            XmlNode padreBicep = xmlDoc.CreateNode(XmlNodeType.Element, "biceps", null);
            XmlNode padreTricep = xmlDoc.CreateNode(XmlNodeType.Element, "triceps", null);
            XmlNode padrePecho = xmlDoc.CreateNode(XmlNodeType.Element, "pecho", null);
            XmlNode padreEspalda = xmlDoc.CreateNode(XmlNodeType.Element, "espalda", null);
            XmlNode padreHombros = xmlDoc.CreateNode(XmlNodeType.Element, "hombros", null);
            XmlNode padreAbs = xmlDoc.CreateNode(XmlNodeType.Element, "abs", null);

            XmlNode estadoBicep = xmlDoc.CreateElement("estado");
            estadoBicep.InnerText = "0";

            XmlNode estadoTricep = xmlDoc.CreateElement("estado");
            estadoTricep.InnerText = "0";

            XmlNode estadoPecho = xmlDoc.CreateElement("estado");
            estadoPecho.InnerText = "0";

            XmlNode estadoEspalda = xmlDoc.CreateElement("estado");
            estadoEspalda.InnerText = "0";

            XmlNode estadoHombros = xmlDoc.CreateElement("estado");
            estadoHombros.InnerText = "0";

            XmlNode estadoAbs = xmlDoc.CreateElement("estado");
            estadoAbs.InnerText = "0";

            XmlNode nivelsito1 = xmlDoc.CreateElement("nivel");
            nivelsito1.InnerText = "0";

            XmlNode exp1 = xmlDoc.CreateElement("exp");
            exp1.InnerText = "0";

            XmlNode nivelsito2 = xmlDoc.CreateElement("nivel");
            nivelsito2.InnerText = "0";

            XmlNode exp2 = xmlDoc.CreateElement("exp");
            exp2.InnerText = "0";

            XmlNode nivelsito3 = xmlDoc.CreateElement("nivel");
            nivelsito3.InnerText = "0";

            XmlNode exp3 = xmlDoc.CreateElement("exp");
            exp3.InnerText = "0";

            XmlNode nivelsito4 = xmlDoc.CreateElement("nivel");
            nivelsito4.InnerText = "0";

            XmlNode exp4 = xmlDoc.CreateElement("exp");
            exp4.InnerText = "0";

            XmlNode nivelsito5 = xmlDoc.CreateElement("nivel");
            nivelsito5.InnerText = "0";

            XmlNode exp5 = xmlDoc.CreateElement("exp");
            exp5.InnerText = "0";

            XmlNode nivelsito6 = xmlDoc.CreateElement("nivel");
            nivelsito6.InnerText = "0";

            XmlNode exp6 = xmlDoc.CreateElement("exp");
            exp6.InnerText = "0";

            padreBicep.AppendChild(nivelsito1);
            padreBicep.AppendChild(exp1);
            padreBicep.AppendChild(estadoBicep);

            padreTricep.AppendChild(nivelsito2);
            padreTricep.AppendChild(exp2);
            padreTricep.AppendChild(estadoTricep);

            padrePecho.AppendChild(nivelsito3);
            padrePecho.AppendChild(exp3);
            padrePecho.AppendChild(estadoPecho);

            padreEspalda.AppendChild(nivelsito4);
            padreEspalda.AppendChild(exp4);
            padreEspalda.AppendChild(estadoEspalda);

            padreHombros.AppendChild(nivelsito5);
            padreHombros.AppendChild(exp5);
            padreHombros.AppendChild(estadoHombros);

            padreAbs.AppendChild(nivelsito6);
            padreAbs.AppendChild(exp6);
            padreAbs.AppendChild(estadoAbs);

            /* Añadir hijos al padre */
            padre.AppendChild(hijoCuenta);
            padre.AppendChild(hijoClave);
            padre.AppendChild(hijoNombre);
            padre.AppendChild(hijoApellido);
            padre.AppendChild(hijoFoto);
            padre.AppendChild(hijoFecha);
            padre.AppendChild(nivelsito);
            padre.AppendChild(exp);
            
            padre.AppendChild(padreBicep);
            padre.AppendChild(padreTricep);
            padre.AppendChild(padrePecho);
            padre.AppendChild(padreEspalda);
            padre.AppendChild(padreHombros);
            padre.AppendChild(padreAbs);

            /* Integrar nuevo padre a la familia */
            xmlDoc.DocumentElement.AppendChild(padre);
            xmlDoc.Save(path);

            return true;
        }

        public string getNombre(string user)
        {
            string ret = "";
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(path);

            XmlNodeList accountNames = xmlDoc.GetElementsByTagName("accountName");
            XmlNodeList nombres = xmlDoc.GetElementsByTagName("nombre");

            for (int i = 0; i < accountNames.Count; i++)
                if (accountNames[i].InnerText == user)
                    ret = nombres[i].InnerText; 

            return ret;
        }

        public string getApellido(string user)
        {
            string ret = "";
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(path);

            XmlNodeList accountNames = xmlDoc.GetElementsByTagName("accountName");
            XmlNodeList apellidos = xmlDoc.GetElementsByTagName("apellido");

            for (int i = 0; i < accountNames.Count; i++)
                if (accountNames[i].InnerText == user)
                    ret = apellidos[i].InnerText; 

            return ret;
        }

        public string getImgURL(string user)
        {
            string ret = "";
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(path);

            XmlNodeList accountNames = xmlDoc.GetElementsByTagName("accountName");
            XmlNodeList url = xmlDoc.GetElementsByTagName("imgUrl");

            for (int i = 0; i < accountNames.Count; i++)
                if (accountNames[i].InnerText == user)
                    ret = url[i].InnerText;

            return ret;
        }

        public string getFecha(string user)
        {
            string ret = "";
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(path);

            XmlNodeList accountNames = xmlDoc.GetElementsByTagName("accountName");
            XmlNodeList date = xmlDoc.GetElementsByTagName("created");

            for (int i = 0; i < accountNames.Count; i++)
                if (accountNames[i].InnerText == user)
                    ret = date[i].InnerText;

            return ret;
        }

        public string getNivel(string user, int id)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(path);

            XmlNodeList db = xmlDoc.ChildNodes;
            XmlNodeList lista = db[0].ChildNodes;

            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].FirstChild.InnerText == user)
                {
                    XmlNodeList listaDos = lista[i].ChildNodes; // Obtener los hijos de un USER
                    
                    /* Chequeamos si se pide el nivel del usuario */
                    if (id == USER)                    
                        return listaDos[6].InnerText;

                    /* Si es algun musculo.. */
                    for (int k = 0; k < listaDos.Count; k++)
                    {
                        switch (id)
                        {
                            case BICEPS:
                                if (listaDos[k].Name == "biceps")                                
                                    return (listaDos[k].ChildNodes)[0].InnerText;                                
                                break;
                            case TRICEPS:
                                if (listaDos[k].Name == "triceps")
                                    return (listaDos[k].ChildNodes)[0].InnerText; 
                                break;
                            case PECHO:
                                if (listaDos[k].Name == "pecho")
                                    return (listaDos[k].ChildNodes)[0].InnerText; 
                                break;
                            case ESPALDA:
                                if (listaDos[k].Name == "espalda")
                                    return (listaDos[k].ChildNodes)[0].InnerText; 
                                break;
                            case HOMBROS:
                                if (listaDos[k].Name == "hombros")
                                    return (listaDos[k].ChildNodes)[0].InnerText; 
                                break;
                            case ABS:
                                if (listaDos[k].Name == "abs")
                                    return (listaDos[k].ChildNodes)[0].InnerText; 
                                break;
                        }
                    }

                    /* ----- */
                }
            }

            return null;
        }

        public string getExp(string user, int id)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(path);

            XmlNodeList db = xmlDoc.ChildNodes;
            XmlNodeList lista = db[0].ChildNodes;

            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].FirstChild.InnerText == user)
                {
                    XmlNodeList listaDos = lista[i].ChildNodes; // Obtener los hijos de un USER

                    /* Chequeamos si se pide el nivel del usuario */
                    if (id == USER)
                        return listaDos[7].InnerText;

                    /* Si es algun musculo.. */
                    for (int k = 0; k < listaDos.Count; k++)
                    {
                        switch (id)
                        {
                            case BICEPS:
                                if (listaDos[k].Name == "biceps")
                                    return (listaDos[k].ChildNodes)[1].InnerText;
                                break;
                            case TRICEPS:
                                if (listaDos[k].Name == "triceps")
                                    return (listaDos[k].ChildNodes)[1].InnerText;
                                break;
                            case PECHO:
                                if (listaDos[k].Name == "pecho")
                                    return (listaDos[k].ChildNodes)[1].InnerText;
                                break;
                            case ESPALDA:
                                if (listaDos[k].Name == "espalda")
                                    return (listaDos[k].ChildNodes)[1].InnerText;
                                break;
                            case HOMBROS:
                                if (listaDos[k].Name == "hombros")
                                    return (listaDos[k].ChildNodes)[1].InnerText;
                                break;
                            case ABS:
                                if (listaDos[k].Name == "abs")
                                    return (listaDos[k].ChildNodes)[1].InnerText;
                                break;
                        }
                    }

                    /* ----- */
                }
            }

            return null;
        }

        public string getEstado(string user, int id)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(path);

            XmlNodeList db = xmlDoc.ChildNodes;
            XmlNodeList lista = db[0].ChildNodes;

            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].FirstChild.InnerText == user)
                {
                    XmlNodeList listaDos = lista[i].ChildNodes; // Obtener los hijos de un USER

                    for (int k = 0; k < listaDos.Count; k++)
                    {
                        switch (id)
                        {
                            case BICEPS:
                                if (listaDos[k].Name == "biceps")
                                    return (listaDos[k].ChildNodes)[2].InnerText;
                                break;
                            case TRICEPS:
                                if (listaDos[k].Name == "triceps")
                                    return (listaDos[k].ChildNodes)[2].InnerText;
                                break;
                            case PECHO:
                                if (listaDos[k].Name == "pecho")
                                    return (listaDos[k].ChildNodes)[2].InnerText;
                                break;
                            case ESPALDA:
                                if (listaDos[k].Name == "espalda")
                                    return (listaDos[k].ChildNodes)[2].InnerText;
                                break;
                            case HOMBROS:
                                if (listaDos[k].Name == "hombros")
                                    return (listaDos[k].ChildNodes)[2].InnerText;
                                break;
                            case ABS:
                                if (listaDos[k].Name == "abs")
                                    return (listaDos[k].ChildNodes)[2].InnerText;
                                break;
                        }
                    }

                    /* ----- */
                }
            }

            return null;
        }

        public void addRutina(int id, string user, string motivacion, string tiempoTotal, string setsTotales, string reps)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(path);

            XmlNodeList db = xmlDoc.ChildNodes;
            XmlNodeList lista = db[0].ChildNodes;

            /* Crear rutina nueva */
            XmlNode padreRutina = xmlDoc.CreateNode(XmlNodeType.Element, "rutina", null);

            XmlNode motiv = xmlDoc.CreateElement("motivacion");
            motiv.InnerText = motivacion;

            XmlNode tTotal = xmlDoc.CreateElement("tiempoTotal");
            tTotal.InnerText = tiempoTotal;

            XmlNode totalSets = xmlDoc.CreateElement("setsTotales");
            totalSets.InnerText = setsTotales;

            XmlNode nroReps = xmlDoc.CreateElement("reps");
            nroReps.InnerText = reps;

            padreRutina.AppendChild(motiv);
            padreRutina.AppendChild(tTotal);
            padreRutina.AppendChild(totalSets);
            padreRutina.AppendChild(nroReps);


            for (int i = 0; i < lista.Count; i++) // Recorrer los USER
            {
                string asdfmovie = lista[i].FirstChild.InnerText;
                if (lista[i].FirstChild.InnerText == user)
                {
                    XmlNodeList listaDos = lista[i].ChildNodes; // Obtener los hijos de un USER
                    for (int k = 0; k < listaDos.Count; k++)
                    {
                        switch (id)
                        {
                            case BICEPS:
                                if (listaDos[k].Name == "biceps")
                                {
                                    listaDos[k].AppendChild(padreRutina);

                                    lista[i].AppendChild(listaDos[k]);
                                    xmlDoc.DocumentElement.AppendChild(lista[i]);
                                    xmlDoc.Save(path);
                                    return;
                                }
                                break;
                            case TRICEPS:
                                if (listaDos[k].Name == "triceps")
                                {
                                    listaDos[k].AppendChild(padreRutina);

                                    lista[i].AppendChild(listaDos[k]);
                                    xmlDoc.DocumentElement.AppendChild(lista[i]);
                                    xmlDoc.Save(path);
                                    return;
                                }
                                break;
                            case PECHO:
                                if (listaDos[k].Name == "pecho")
                                {
                                    listaDos[k].AppendChild(padreRutina);

                                    lista[i].AppendChild(listaDos[k]);
                                    xmlDoc.DocumentElement.AppendChild(lista[i]);
                                    xmlDoc.Save(path);
                                    return;
                                }
                                break;
                            case ESPALDA:
                                if (listaDos[k].Name == "espalda")
                                {
                                    listaDos[k].AppendChild(padreRutina);

                                    lista[i].AppendChild(listaDos[k]);
                                    xmlDoc.DocumentElement.AppendChild(lista[i]);
                                    xmlDoc.Save(path);
                                    return;
                                }
                                break;
                            case HOMBROS:
                                if (listaDos[k].Name == "hombros")
                                {
                                    listaDos[k].AppendChild(padreRutina);

                                    lista[i].AppendChild(listaDos[k]);
                                    xmlDoc.DocumentElement.AppendChild(lista[i]);
                                    xmlDoc.Save(path);
                                    return;
                                }
                                break;
                            case ABS:
                                if (listaDos[k].Name == "abs")
                                {
                                    listaDos[k].AppendChild(padreRutina);

                                    lista[i].AppendChild(listaDos[k]);
                                    xmlDoc.DocumentElement.AppendChild(lista[i]);
                                    xmlDoc.Save(path);
                                    return;
                                }
                                break;
                        }                        
                    }
                }
            }
        }
    }
}
