using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._2
{
    class ManejadorArchivoXml : ManejadorArchivo
    {
        protected DataSet ds;

        public override DataTable getTabla()
        {
            this.ds = new DataSet();
            this.ds.ReadXml("agenda.xml");
            return this.ds.Tables["contactos"];
        }

        public override void aplicaCambios()
        {
            this.ds.WriteXml("agenda.xml");
            this.ds.WriteXml("agendaconschema.xml", XmlWriteMode.WriteSchema);
        }
    }
}
