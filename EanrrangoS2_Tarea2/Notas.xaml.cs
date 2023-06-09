﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EanrrangoS2_Tarea2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Notas : ContentPage

        
    {

        
        public Notas(string usuario)
        {   
            InitializeComponent();
            lblUsuario.Text = usuario;
            

        }



        private void btnAprobacion_Clicked(object sender, EventArgs e)
        {

            //string aprobacion = txtParcial2.Text;

           // DisplayAlert("Felicitacidades..", "Curso Aprobado " + aprobacion, "Cerrar");

        }
        double notaSeg;
        double notaExa1;
        double notaPar1;

        private void btnCalcParcial1_Clicked(object sender, EventArgs e)
        {
            notaSeg = Convert.ToDouble(txtSegNota1.Text);
            notaExa1 = Convert.ToDouble(txtExam1.Text);
             //notaPar1 = Convert.ToDouble(txtParcial1.Text);


            // double suma = notaSeg + notaExa1;

         if (!string.IsNullOrEmpty(txtSegNota1.Text) && !string.IsNullOrEmpty(txtExam1.Text))
          {
                if (txtSegNota1.Text != null && txtExam1.Text != null)
                {

              
                    if (notaSeg > 0 && notaSeg <= 10)
                    {
                         if (notaExa1 > 0 && notaExa1 <= 10)
                        {
                        double suma = notaSeg * 0.3 + notaExa1 * 0.2;

                        txtParcial1.Text = suma.ToString();
                        }
                        else
                         {
                                DisplayAlert("Error..", "La Nota del Examne 1 debe estar entre: 0.1 - 10", "cerrar");
                          }

                    }
                  else
                    {
                        DisplayAlert("Error..", "La Nota de Seguimiento 1 debe estar entre: 0.1 - 10", "cerrar");

                    }
            }



          }
         else
            {
                DisplayAlert("Alerta", "Los campos de se encuentran vacios ", "cerrar");

            }



        }

        double notaSeg2;
        double notaExa2;

        private void btnCalcParcial2_Clicked(object sender, EventArgs e)
        {

             notaSeg2 = Convert.ToDouble(txtSegNota2.Text);
             notaExa2 = Convert.ToDouble(txtExam2.Text);

            //double suma2 = notaSeg2 + notaExa2;

            //txtParcial2.Text = suma2.ToString();
            if (!string.IsNullOrEmpty(txtSegNota2.Text) && !string.IsNullOrEmpty(txtExam2.Text))
            {

                if (txtSegNota2.Text != null && txtExam2.Text != null)
               {

                        if (notaSeg2 > 0 && notaSeg2 <= 10)
                        {
                            if (notaExa2 > 0 && notaExa2 <= 10)
                            {
                                double suma2 = notaSeg2 * 0.3 + notaExa2 * 0.2;

                                txtParcial2.Text = suma2.ToString();
                            }
                            else
                            {
                                DisplayAlert("Error..", "La Nota del Examne 2 debe estar entre: 0.1 - 10", "cerrar");
                            }

                        }
                        else
                        {
                            DisplayAlert("Error..", "La Nota de Seguimiento 2 debe estar entre: 0.1 - 10", "cerrar");

                        }
                }
           
            }
            else
            {
                DisplayAlert("Alerta", "Los campos de se encuentran vacios ", "cerrar");
            }

        }

        double aprob;

        private void btnAprobado_Clicked(object sender, EventArgs e)
        {

          if (!string.IsNullOrEmpty(txtParcial1.Text) && !string.IsNullOrEmpty(txtParcial2.Text))
          {
                aprob = Convert.ToDouble(txtParcial1.Text) + Convert.ToDouble(txtParcial2.Text);

            if (aprob >= 7)
            {
                DisplayAlert("Felicidades ..", "Semestre esta Aprobado .. " + aprob, "Cerrar");

            }

            else if ((aprob >= 5) && (aprob < 7))
            {
                DisplayAlert("Tiene un Examen Complementario ..", "Semestre No Aprobado .. " + aprob, "Cerrar");
            }

            else
              {
                 DisplayAlert("Failed ..", "Semestre Reprobado .. " + aprob, "Cerrar");
              }
          }
          else
            {
                DisplayAlert("Alerta", "Los campos de se encuentran vacios ", "cerrar");
            }
        }

        private void and(bool v)
        {
            throw new NotImplementedException();
        }

        private void btnLimpiar_Clicked(object sender, EventArgs e)
        {
           txtSegNota1.Text="";
           txtExam1.Text = "";
           txtParcial1.Text = "";
           txtSegNota2.Text = "";
           txtExam2.Text = "";
           txtParcial2.Text = "";
        }


    }
}