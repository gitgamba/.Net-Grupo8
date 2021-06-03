using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabGrilla_Juani
{
    public partial class formListaUsuarios : Form
    {
        private Usuarios _usuarios;

        public formListaUsuarios()
        {
            InitializeComponent();
            this.oUsuarios = new Negocio.Usuarios();    //instanciamos oUsuarios para obtener la DataTable del metodo GetAll de oUsuarios y mostrar en grilla
            this.dgvUsuarios.DataSource = this.oUsuarios.GetAll();
            GenerarColumnas();
            getTiposDocumento();
            //Aca empiezan los this del calendario
            this.dataGridView1.Dock = DockStyle.Fill;
            this.Controls.Add(this.dataGridView1);
            this.Load += new EventHandler(Form1_Load);
            this.Text = "DataGridView calendar column demo";
            //Aca terminan los this del calendario
            this.dgvUsuarios.AutoGenerateColumns = false;
            this.oUsuarios = new Negocio.Usuarios();
            this.dgvUsuarios.DataSource = this.oUsuarios.GetAll();
        }
        public Negocio.Usuarios oUsuarios       //sirve para recuperar los datos y visualizarlos
        {
            get { return _usuarios; }
            set { _usuarios = value; }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.GuardarCambios();  //invoca al GuardarCambios de oUsuarios y realiza cambios en la BD
            this.RecargarGrilla();  //invoca al GetAll de oUsuarios para volver a realizar consulta de los usuarios y mostrarlos
        }
        private void RecargarGrilla()
        {
            this.dgvUsuarios.DataSource = this.oUsuarios.GetAll();
        }
        private void GuardarCambios()
        {
            this.oUsuarios.GuardarCambios((DataTable)this.dgvUsuarios.DataSource);
        }
        private void GenerarColumnas()
        {
            //Creando la columna Nro. Documento
            DataGridViewTextBoxColumn colNroDoc = new DataGridViewTextBoxColumn();
            //Creamos la nueva columna y definimos el tipo de columna
            colNroDoc.Name = "nro_doc";
            //Asignamos un nombre a la columna
            colNroDoc.HeaderText = "Nro. Documento";
            //Indicamos el titulo a mostrar
            colNroDoc.DataPropertyName = "nro_doc";
            //Indicamos con cual columna del DataTable que asignamos al DataSource de la grilla debe vincularse
            colNroDoc.DisplayIndex = 0;
            //en qué posicion debe mostrarse, todas las columnas a la derecha de la posicion que indiquemos se moverán una
            //posicion a la derecha

            this.dgvUsuarios.Columns.Add(colNroDoc);
            //agregamos la columna al DataGridView para que la muestre

            //Columna tipo documento
            DataGridViewComboBoxColumn colTipoDoc = new DataGridViewComboBoxColumn();
            colTipoDoc.Name = "tipo_doc";
            colTipoDoc.HeaderText = "Tipo Documento";
            colTipoDoc.DataPropertyName = "tipo_doc";
            colTipoDoc.DisplayIndex = 0;

            /*//Agrego items manualmente
            colTipoDoc.Items.Add(1);
            colTipoDoc.Items.Add(2);
            colTipoDoc.Items.Add(3);
            colTipoDoc.Items.Add(4);
            colTipoDoc.Items.Add(5);*/

            //Asigno la lista de items que son válidos
            colTipoDoc.DataSource = this.getTiposDocumento();

            //Indico que el valor interno del combo es el valor de la fila elegida y la columna cod_tipo_doc del DataSource que
            //asigné a la columna colTipoDoc
            colTipoDoc.ValueMember = "cod_tipo_doc";

            //indo que el valor que se muestra al usuario es el que se corresponde con la columna desc_tipo_doc del DataSource que
            //asigné a colTipoDoc independientemente de la columna de la cual obtiene su valor
            colTipoDoc.DisplayMember = "desc_tipo_doc";

            this.dgvUsuarios.Columns.Add(colTipoDoc);

            DataGridViewTextBoxColumn colTel = new DataGridViewTextBoxColumn();
            colTel.Name = "telefono";
            colTel.HeaderText = "Teléfono";
            colTel.DataPropertyName = "telefono";

            DataGridViewTextBoxColumn colEmail = new DataGridViewTextBoxColumn();
            colEmail.Name = "email";
            colEmail.HeaderText = "E-Mail";
            colEmail.DataPropertyName = "email";

            DataGridViewTextBoxColumn colCel = new DataGridViewTextBoxColumn();
            colCel.Name = "celular";
            colCel.HeaderText = "Celular";
            colCel.DataPropertyName = "celular";

            DataGridViewTextBoxColumn colUsuario = new DataGridViewTextBoxColumn();
            colUsuario.Name = "usuario";
            colUsuario.HeaderText = "Usuario";
            colUsuario.DataPropertyName = "usuario";

            DataGridViewTextBoxColumn colClave = new DataGridViewTextBoxColumn();
            colClave.Name = "clave";
            colClave.HeaderText = "Clave";
            colClave.DataPropertyName = "clave";

            colEmail.Width = 250;
            colNroDoc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            colClave.Visible = false;

            //como las columnas direccion, nombre, apellido y fecha de nacimiento las creamos con el diseñador de formularios no disponemos
            //de una variable para hacer  referencia a ellas. Entonces debemos referenciarlas con this.dgvUsuarios.Columns["nombre_columna"]
            //donde el nombre_columna es lo que indicamos en la propiedad Name de las columnas
            this.dgvUsuarios.Columns["direccion"].Width = 250;
            this.dgvUsuarios.Columns["apellido"].DefaultCellStyle.Font =
            new Font(this.dgvUsuarios.DefaultCellStyle.Font, FontStyle.Bold);
            this.dgvUsuarios.Columns["nombre"].DefaultCellStyle.Font =
            new Font(this.dgvUsuarios.DefaultCellStyle.Font, FontStyle.Bold);
            this.dgvUsuarios.Columns["fecha_nac"].DefaultCellStyle.Alignment =
            DataGridViewContentAlignment.MiddleRight;

            this.dgvUsuarios.Columns.Add(colTel);
            this.dgvUsuarios.Columns.Add(colEmail);
            this.dgvUsuarios.Columns.Add(colCel);
            this.dgvUsuarios.Columns.Add(colUsuario);
            this.dgvUsuarios.Columns.Add(colClave);
        }
        private DataTable getTiposDocumento()
        {
            //Creo DataTable
            DataTable dtTiposDoc = new DataTable();

            //Agrego columnas al DataTable
            dtTiposDoc.Columns.Add("cod_tipo_doc", typeof(int));
            dtTiposDoc.Columns.Add("desc_tipo_doc", typeof(string));

            //Agrego filas al DataTable
            dtTiposDoc.Rows.Add(new object[] { 1, "DNI" });
            dtTiposDoc.Rows.Add(new object[] { 2, "Cédula" });
            dtTiposDoc.Rows.Add(new object[] { 3, "Pasaporte" });
            dtTiposDoc.Rows.Add(new object[] { 4, "Libreta Cívica" });
            dtTiposDoc.Rows.Add(new object[] { 5, "Libreta Enrolamiento" });

            return dtTiposDoc;
        }


//------------------------------CALENDARIO------------------------------------------------------------------------------
        private DataGridView dataGridView1 = new DataGridView();

        private void Form1_Load(object sender, EventArgs e)
        {
            CalendarColumn col = new CalendarColumn();
            this.dataGridView1.Columns.Add(col);
            this.dataGridView1.RowCount = 5;
            foreach (DataGridViewRow row in this.dataGridView1.Rows)
            {
                row.Cells[0].Value = DateTime.Now;
            }
        }
        public class CalendarColumn : DataGridViewColumn
    {
    public CalendarColumn() : base(new CalendarCell())
    {
    }
    public override DataGridViewCell CellTemplate
    {
            get
            {
                return base.CellTemplate;
            }
            set
            {
                // Ensure that the cell used for the template is a CalendarCell.
                if (value != null &&
                    !value.GetType().IsAssignableFrom(typeof(CalendarCell)))
                {
                    throw new InvalidCastException("Must be a CalendarCell");
                }
                base.CellTemplate = value;
            }
    }
    }
    public class CalendarCell : DataGridViewTextBoxCell
    {
        public CalendarCell()
            : base()
        {
            // Use the short date format.
            this.Style.Format = "d";
        }
        public override void InitializeEditingControl(int rowIndex, object
            initialFormattedValue, DataGridViewCellStyle dataGridViewCellStyle)
        {
            // Set the value of the editing control to the current cell value.
            base.InitializeEditingControl(rowIndex, initialFormattedValue,
                dataGridViewCellStyle);
            CalendarEditingControl ctl =
                DataGridView.EditingControl as CalendarEditingControl;
            // Use the default row value when Value property is null.
            if (this.Value == null)
            {
                ctl.Value = (DateTime)this.DefaultNewRowValue;
            }
            else
            {
                ctl.Value = (DateTime)this.Value;
            }
        }
        public override Type EditType
        {
            get
            {
                // Return the type of the editing control that CalendarCell uses.
                return typeof(CalendarEditingControl);
            }
        }
        public override Type ValueType
        {
            get
            {
                // Return the type of the value that CalendarCell contains.

                return typeof(DateTime);
            }
        }
        public override object DefaultNewRowValue
        {
            get
            {
                // Use the current date and time as the default value.
                return DateTime.Now;
            }
        }
    }
    class CalendarEditingControl : DateTimePicker, IDataGridViewEditingControl
    {
        DataGridView dataGridView;
        private bool valueChanged = false;
        int rowIndex;

        public CalendarEditingControl()
        {
            this.Format = DateTimePickerFormat.Short;
        }
        // Implements the IDataGridViewEditingControl.EditingControlFormattedValue
        // property.
        public object EditingControlFormattedValue
        {
            get
            {
                return this.Value.ToShortDateString();
            }
            set
            {
                if (value is String)
                {
                    try
                    {
                        // This will throw an exception of the string is
                        // null, empty, or not in the format of a date.
                        this.Value = DateTime.Parse((String)value);
                    }
                    catch
                    {
                        // In the case of an exception, just use the
                        // default value so we're not left with a null
                        // value.
                        this.Value = DateTime.Now;
                    }
                }
            }
        }
        // Implements the
        // IDataGridViewEditingControl.GetEditingControlFormattedValue method.
        public object GetEditingControlFormattedValue(
            DataGridViewDataErrorContexts context)
        {
            return EditingControlFormattedValue;
        }
        // Implements the
        // IDataGridViewEditingControl.ApplyCellStyleToEditingControl method.
        public void ApplyCellStyleToEditingControl(
            DataGridViewCellStyle dataGridViewCellStyle)
        {
            this.Font = dataGridViewCellStyle.Font;
            this.CalendarForeColor = dataGridViewCellStyle.ForeColor;
            this.CalendarMonthBackground = dataGridViewCellStyle.BackColor;
        }
        // Implements the IDataGridViewEditingControl.EditingControlRowIndex
        // property.
        public int EditingControlRowIndex
        {
            get
            {
                return rowIndex;
            }
            set
            {
                rowIndex = value;
            }
        }
        // Implements the IDataGridViewEditingControl.EditingControlWantsInputKey
        // method.
        public bool EditingControlWantsInputKey(
            Keys key, bool dataGridViewWantsInputKey)
        {
            // Let the DateTimePicker handle the keys listed.
            switch (key & Keys.KeyCode)
            {
                case Keys.Left:
                case Keys.Up:
                case Keys.Down:
                case Keys.Right:
                case Keys.Home:
                case Keys.End:
                case Keys.PageDown:
                case Keys.PageUp:
                    return true;
                default:
                    return !dataGridViewWantsInputKey;
            }
        }
        // Implements the IDataGridViewEditingControl.PrepareEditingControlForEdit
        // method.
        public void PrepareEditingControlForEdit(bool selectAll)
        {
            // No preparation needs to be done.
        }
        // Implements the IDataGridViewEditingControl
        // .RepositionEditingControlOnValueChange property.
        public bool RepositionEditingControlOnValueChange
        {
            get
            {
                return false;
            }
        }
        // Implements the IDataGridViewEditingControl
        // .EditingControlDataGridView property.
        public DataGridView EditingControlDataGridView
        {
            get
            {
                return dataGridView;
            }
            set
            {
                dataGridView = value;
            }
        }
        // Implements the IDataGridViewEditingControl
        // .EditingControlValueChanged property.
        public bool EditingControlValueChanged
        {
            get
            {
                return valueChanged;
            }
            set
            {
                valueChanged = value;
            }
        }
        // Implements the IDataGridViewEditingControl
        // .EditingPanelCursor property.
        public Cursor EditingPanelCursor
        {
            get
            {
                return base.Cursor;
            }
        }
        protected override void OnValueChanged(EventArgs eventargs)
        {
            // Notify the DataGridView that the contents of the cell
            // have changed.
            valueChanged = true;
            this.EditingControlDataGridView.NotifyCurrentCellDirty(true);
            base.OnValueChanged(eventargs);
        }
    }
}
}
