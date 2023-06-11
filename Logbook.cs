using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;




namespace Icarus_Software
{
    public partial class Logbook : Form
    {
        public Logbook()
        {
            InitializeComponent();
        }       

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control control in Controls) if (control is TextBox textBox) textBox.Text = ""; else if (control is MaskedTextBox maskedTextBox) maskedTextBox.Text = "";
        }

        private int CalcTotalHou(MaskedTextBox hStart, MaskedTextBox hStop)
        {
            var houStart = int.Parse(hStart.Text.Substring(0, 2));
            var houStop = int.Parse(hStop.Text.Substring(0, 2));                       

            if (houStart > houStop) return (24 - houStart) + 24 - (24 - houStop);          
            else return houStop - houStart;                        
        }

        private int CalcTotalMin(MaskedTextBox mStart, MaskedTextBox mStop)
        {
            var minStart = int.Parse(mStart.Text.Substring(3, 2));
            var minStop = int.Parse(mStop.Text.Substring(3, 2));

            if (minStart == 00 && minStop == 00) return minStart + minStop;
            else return (60 - minStart) + minStop;
        }

        private void Resultado(MaskedTextBox start, MaskedTextBox stop, MaskedTextBox final)
        {
            int horaFinal = CalcTotalHou(start, stop);
            int minutoFinal = CalcTotalMin(start, stop);                   
                      
            if (minutoFinal > 60) minutoFinal = minutoFinal - 60;
            if (minutoFinal <= 3) horaFinal = horaFinal - 1;
            if (horaFinal == 0) horaFinal ++;
            if (horaFinal == 0 && (minutoFinal >= 58 && minutoFinal <= 59)) horaFinal++;


            if (00 <= minutoFinal && minutoFinal <= 3) minutoFinal = 0;
            else if (4 <= minutoFinal && minutoFinal <= 9) minutoFinal = 1;
            else if (10 <= minutoFinal && minutoFinal <= 15) minutoFinal = 2;
            else if (16 <= minutoFinal && minutoFinal <= 21) minutoFinal = 3;
            else if (22 <= minutoFinal && minutoFinal <= 27) minutoFinal = 4;
            else if (28 <= minutoFinal && minutoFinal <= 33) minutoFinal = 5;
            else if (34 <= minutoFinal && minutoFinal <= 39) minutoFinal = 6;
            else if (40 <= minutoFinal && minutoFinal <= 45) minutoFinal = 7;
            else if (46 <= minutoFinal && minutoFinal <= 51) minutoFinal = 8;
            else if (52 <= minutoFinal && minutoFinal <= 57) minutoFinal = 9;
            else if (minutoFinal == 58 || minutoFinal == 59) minutoFinal = 0;                      

            string hourTotal = horaFinal.ToString();
            string minuteTotal = minutoFinal.ToString();
            final.Text = hourTotal + "." + minuteTotal;
        }

        private void MskPouso1_Leave(object sender, EventArgs e)
        {
            Resultado(MskDec1, MskPouso1, MskVoo1);
            CalculoTotais1(MskVoo1, MskVoo2, MskVoo3, MskVoo4, MskVoo5, MskVoo6, MskVooTotal);

            var horasAnt = float.Parse(MskHorasAnteriores.Text);
            var horasVoo = float.Parse(MskVooTotal.Text.Substring(0, 3));
            float horasTotais = horasAnt + horasVoo;
            MskHorasTotais.Text = horasTotais.ToString("00000.0");
        }

        private void MskCorte1_Leave(object sender, EventArgs e)
        {
            Resultado(MskAcion1, MskCorte1, MskTotal1);
            CalculoTotais1(MskTotal1, MskTotal2, MskTotal3, MskTotal4, MskTotal5, MskTotal6, MskTotalTotal);
        }

        private void MskPouso2_Leave(object sender, EventArgs e)
        {
            Resultado(MskDec2, MskPouso2, MskVoo2);
            CalculoTotais2(MskVoo1, MskVoo2, MskVoo3, MskVoo4, MskVoo5, MskVoo6, MskVooTotal);

            var horasAnt = float.Parse(MskHorasAnteriores.Text);
            var horasVoo = float.Parse(MskVooTotal.Text.Substring(0, 3));
            float horasTotais = horasAnt + horasVoo;
            MskHorasTotais.Text = horasTotais.ToString("00000.0");
        }

        private void MskCorte2_Leave(object sender, EventArgs e)
        {
            Resultado(MskAcion2, MskCorte2, MskTotal2);
            CalculoTotais2(MskTotal1, MskTotal2, MskTotal3, MskTotal4, MskTotal5, MskTotal6, MskTotalTotal);
        }

        private void MskPouso3_Leave(object sender, EventArgs e)
        {
            Resultado(MskDec3, MskPouso3, MskVoo3);
            CalculoTotais3(MskVoo1, MskVoo2, MskVoo3, MskVoo4, MskVoo5, MskVoo6, MskVooTotal);

            var horasAnt = float.Parse(MskHorasAnteriores.Text);
            var horasVoo = float.Parse(MskVooTotal.Text.Substring(0, 3));
            float horasTotais = horasAnt + horasVoo;
            MskHorasTotais.Text = horasTotais.ToString("00000.0");
        }

        private void MskCorte3_Leave(object sender, EventArgs e)
        {
            Resultado(MskAcion3, MskCorte3, MskTotal3);
            CalculoTotais3(MskTotal1, MskTotal2, MskTotal3, MskTotal4, MskTotal5, MskTotal6, MskTotalTotal);
        }

        private void MskPouso4_Leave(object sender, EventArgs e)
        {
            Resultado(MskDec4, MskPouso4, MskVoo4);
            CalculoTotais4(MskVoo1, MskVoo2, MskVoo3, MskVoo4, MskVoo5, MskVoo6, MskVooTotal);

            var horasAnt = float.Parse(MskHorasAnteriores.Text);
            var horasVoo = float.Parse(MskVooTotal.Text.Substring(0, 3));
            float horasTotais = horasAnt + horasVoo;
            MskHorasTotais.Text = horasTotais.ToString("00000.0");
        }

        private void MskCorte4_Leave(object sender, EventArgs e)
        {
            Resultado(MskAcion4, MskCorte4, MskTotal4);
            CalculoTotais4(MskTotal1, MskTotal2, MskTotal3, MskTotal4, MskTotal5, MskTotal6, MskTotalTotal);
        }

        private void MskPouso5_Leave(object sender, EventArgs e)
        {
            Resultado(MskDec5, MskPouso5, MskVoo5);
            CalculoTotais5(MskVoo1, MskVoo2, MskVoo3, MskVoo4, MskVoo5, MskVoo6, MskVooTotal);

            var horasAnt = float.Parse(MskHorasAnteriores.Text);
            var horasVoo = float.Parse(MskVooTotal.Text.Substring(0, 3));
            float horasTotais = horasAnt + horasVoo;
            MskHorasTotais.Text = horasTotais.ToString("00000.0");
        }

        private void MskCorte5_Leave(object sender, EventArgs e)
        {
            Resultado(MskAcion5, MskCorte5, MskTotal5);
            CalculoTotais5(MskTotal1, MskTotal2, MskTotal3, MskTotal4, MskTotal5, MskTotal6, MskTotalTotal);
        }

        private void MskPouso6_Leave(object sender, EventArgs e)
        {
            Resultado(MskDec6, MskPouso6, MskVoo6);
            CalculoTotais6(MskVoo1, MskVoo2, MskVoo3, MskVoo4, MskVoo5, MskVoo6, MskVooTotal);

            var horasAnt = float.Parse(MskHorasAnteriores.Text);
            var horasVoo = float.Parse(MskVooTotal.Text.Substring(0, 3));
            float horasTotais = horasAnt + horasVoo;
            MskHorasTotais.Text = horasTotais.ToString("00000.0");
        }

        private void MskCorte6_Leave(object sender, EventArgs e)
        {
            Resultado(MskAcion6, MskCorte6, MskTotal6);
            CalculoTotais6(MskTotal1, MskTotal2, MskTotal3, MskTotal4, MskTotal5, MskTotal6, MskTotalTotal);
        }

        private void CalculoTotais1(MaskedTextBox mTotal1, MaskedTextBox mTotal2, MaskedTextBox mTotal3, MaskedTextBox mTotal4, MaskedTextBox mTotal5, MaskedTextBox mTotal6, MaskedTextBox mTotalTotal)
        {
            float total1 = float.Parse(mTotal1.Text.Trim());
            float total2 = 0.0f;
            float total3 = 0.0f;
            float total4 = 0.0f;
            float total5 = 0.0f;
            float total6 = 0.0f;

            if (float.TryParse(mTotal2.Text, out float resultado2)) total2 = resultado2;
            if (float.TryParse(mTotal3.Text, out float resultado3)) total3 = resultado3;
            if (float.TryParse(mTotal4.Text, out float resultado4)) total4 = resultado4;
            if (float.TryParse(mTotal5.Text, out float resultado5)) total5 = resultado5;
            if (float.TryParse(mTotal6.Text, out float resultado6)) total6 = resultado6;

            float somaTotal = total1 + total2 + total3 + total4 + total5 + total6;
            mTotalTotal.Text = somaTotal.ToString("0.0");
        }

        private void CalculoTotais2(MaskedTextBox mTotal1, MaskedTextBox mTotal2, MaskedTextBox mTotal3, MaskedTextBox mTotal4, MaskedTextBox mTotal5, MaskedTextBox mTotal6, MaskedTextBox mTotalTotal)
        {
            float total1 = float.Parse(mTotal1.Text.Trim());
            float total2 = float.Parse(mTotal2.Text.Trim());
            float total3 = 0.0f;
            float total4 = 0.0f;
            float total5 = 0.0f;
            float total6 = 0.0f;

            if (float.TryParse(mTotal3.Text, out float resultado3)) total3 = resultado3;
            if (float.TryParse(mTotal4.Text, out float resultado4)) total4 = resultado4;
            if (float.TryParse(mTotal5.Text, out float resultado5)) total5 = resultado5;
            if (float.TryParse(mTotal6.Text, out float resultado6)) total6 = resultado6;

            float somaTotal = total1 + total2 + total3 + total4 + total5 + total6;
            mTotalTotal.Text = somaTotal.ToString("0.0");
        }

        private void CalculoTotais3(MaskedTextBox mTotal1, MaskedTextBox mTotal2, MaskedTextBox mTotal3, MaskedTextBox mTotal4, MaskedTextBox mTotal5, MaskedTextBox mTotal6, MaskedTextBox mTotalTotal)
        {
            float total1 = float.Parse(mTotal1.Text.Trim());
            float total2 = float.Parse(mTotal2.Text.Trim());
            float total3 = float.Parse(mTotal3.Text.Trim());
            float total4 = 0.0f;
            float total5 = 0.0f;
            float total6 = 0.0f;

            if (float.TryParse(mTotal4.Text, out float resultado4)) total4 = resultado4;
            if (float.TryParse(mTotal5.Text, out float resultado5)) total5 = resultado5;
            if (float.TryParse(mTotal6.Text, out float resultado6)) total6 = resultado6;

            float somaTotal = total1 + total2 + total3 + total4 + total5 + total6;
            mTotalTotal.Text = somaTotal.ToString("0.0");
        }

        private void CalculoTotais4(MaskedTextBox mTotal1, MaskedTextBox mTotal2, MaskedTextBox mTotal3, MaskedTextBox mTotal4, MaskedTextBox mTotal5, MaskedTextBox mTotal6, MaskedTextBox mTotalTotal)
        {
            float total1 = float.Parse(mTotal1.Text.Trim());
            float total2 = float.Parse(mTotal2.Text.Trim());
            float total3 = float.Parse(mTotal3.Text.Trim());
            float total4 = float.Parse(mTotal4.Text.Trim());
            float total5 = 0.0f;
            float total6 = 0.0f;

            if (float.TryParse(mTotal5.Text, out float resultado5)) total5 = resultado5;
            if (float.TryParse(mTotal6.Text, out float resultado6)) total6 = resultado6;

            float somaTotal = total1 + total2 + total3 + total4 + total5 + total6;
            mTotalTotal.Text = somaTotal.ToString("0.0");
        }

        private void CalculoTotais5(MaskedTextBox mTotal1, MaskedTextBox mTotal2, MaskedTextBox mTotal3, MaskedTextBox mTotal4, MaskedTextBox mTotal5, MaskedTextBox mTotal6, MaskedTextBox mTotalTotal)
        {
            float total1 = float.Parse(mTotal1.Text.Trim());
            float total2 = float.Parse(mTotal2.Text.Trim());
            float total3 = float.Parse(mTotal3.Text.Trim());
            float total4 = float.Parse(mTotal4.Text.Trim());
            float total5 = float.Parse(mTotal5.Text.Trim());
            float total6 = 0.0f;

            if (float.TryParse(mTotal6.Text, out float resultado6)) total6 = resultado6;

            float somaTotal = total1 + total2 + total3 + total4 + total5 + total6;
            mTotalTotal.Text = somaTotal.ToString("0.0");
        }

        private void CalculoTotais6(MaskedTextBox mTotal1, MaskedTextBox mTotal2, MaskedTextBox mTotal3, MaskedTextBox mTotal4, MaskedTextBox mTotal5, MaskedTextBox mTotal6, MaskedTextBox mTotalTotal)
        {
            float total1 = float.Parse(mTotal1.Text.Trim());
            float total2 = float.Parse(mTotal2.Text.Trim());
            float total3 = float.Parse(mTotal3.Text.Trim());
            float total4 = float.Parse(mTotal4.Text.Trim());
            float total5 = float.Parse(mTotal5.Text.Trim());
            float total6 = float.Parse(mTotal6.Text.Trim());

            float somaTotal = total1 + total2 + total3 + total4 + total5 + total6;
            mTotalTotal.Text = somaTotal.ToString("0.0");
        }

        private void CalculadoraVfrDiu(MaskedTextBox totalVfrDiu, MaskedTextBox final)
        {
            int hvi = int.Parse(totalVfrDiu.Text.Substring(0, 2));
            int mvi = int.Parse(totalVfrDiu.Text.Substring(3, 2));

            if (00 <= mvi && mvi <= 3) mvi = 0;
            else if (4 <= mvi && mvi <= 9) mvi = 1;
            else if (10 <= mvi && mvi <= 15) mvi = 2;
            else if (16 <= mvi && mvi <= 21) mvi = 3;
            else if (22 <= mvi && mvi <= 27) mvi = 4;
            else if (28 <= mvi && mvi <= 33) mvi = 5;
            else if (34 <= mvi && mvi <= 39) mvi = 6;
            else if (40 <= mvi && mvi <= 45) mvi = 7;
            else if (46 <= mvi && mvi <= 51) mvi = 8;
            else if (52 <= mvi && mvi <= 57) mvi = 9;
            else if (mvi == 58 || mvi == 59) { mvi = 0; hvi = hvi + 1; }

            double resultado = hvi + (mvi / 10.0);
            final.Text = resultado.ToString("0.0");
        }

        private void CalculadoraIfrNot(MaskedTextBox vooTot, MaskedTextBox vfrNotTot, MaskedTextBox ifrDiuTot)
        {
            float total = float.Parse(vooTot.Text.Substring(0, 3));
            float vfrNot = float.Parse(vfrNotTot.Text.Substring(0, 3));

            float ifrDiuTotal = total - vfrNot;
            ifrDiuTot.Text = ifrDiuTotal.ToString("0.0");
        }
   
        private void MskTotVfr1_Leave(object sender, EventArgs e)
        {
            CalculadoraVfrDiu(MskTotVfr1, MskVfr1);
            CalculadoraIfrNot(MskVoo1, MskVfr1, MskIfr1);
            CalculoTotais1(MskIfr1, MskIfr2, MskIfr3, MskIfr4, MskIfr5, MskIfr6, MskIfrTotal);
            CalculoTotais1(MskVfr1, MskVfr2, MskVfr3, MskVfr4, MskVfr5, MskVfr6, MskVfrTotal);

        }
        private void MskTotNoturno1_Leave(object sender, EventArgs e)
        {
            CalculadoraVfrDiu(MskTotNoturno1, MskNot1);
            CalculadoraIfrNot(MskVoo1, MskNot1, MskDiu1);
            CalculoTotais1(MskDiu1, MskDiu2, MskDiu3, MskDiu4, MskDiu5, MskDiu6, MskDiuTotal);
            CalculoTotais1(MskNot1, MskNot2, MskNot3, MskNot4, MskNot5, MskNot6, MskNotTotal);
        }   

        private void MskTotVfr2_Leave(object sender, EventArgs e)
        {
            CalculadoraVfrDiu(MskTotVfr2, MskVfr2);
            CalculadoraIfrNot(MskVoo2, MskVfr2, MskIfr2);
            CalculoTotais2(MskIfr1, MskIfr2, MskIfr3, MskIfr4, MskIfr5, MskIfr6, MskIfrTotal);
            CalculoTotais2(MskVfr1, MskVfr2, MskVfr3, MskVfr4, MskVfr5, MskVfr6, MskVfrTotal);
        }
                
        private void MskTotNoturno2_Leave(object sender, EventArgs e)
        {
            CalculadoraVfrDiu(MskTotNoturno2, MskNot2);
            CalculadoraIfrNot(MskVoo2, MskNot2, MskDiu2);
            CalculoTotais2(MskDiu1, MskDiu2, MskDiu3, MskDiu4, MskDiu5, MskDiu6, MskDiuTotal);
            CalculoTotais2(MskNot1, MskNot2, MskNot3, MskNot4, MskNot5, MskNot6, MskNotTotal);
        }  

        private void MskTotVfr3_Leave(object sender, EventArgs e)
        {
            CalculadoraVfrDiu(MskTotVfr3, MskVfr3);
            CalculadoraIfrNot(MskVoo3, MskVfr3, MskIfr3);
            CalculoTotais3(MskIfr1, MskIfr2, MskIfr3, MskIfr4, MskIfr5, MskIfr6, MskIfrTotal);
            CalculoTotais3(MskVfr1, MskVfr2, MskVfr3, MskVfr4, MskVfr5, MskVfr6, MskVfrTotal);
        }

        private void MskTotNoturno3_Leave(object sender, EventArgs e)
        {
            CalculadoraVfrDiu(MskTotNoturno3, MskNot3);
            CalculadoraIfrNot(MskVoo3, MskNot3, MskDiu3);
            CalculoTotais3(MskDiu1, MskDiu2, MskDiu3, MskDiu4, MskDiu5, MskDiu6, MskDiuTotal);
            CalculoTotais3(MskNot1, MskNot2, MskNot3, MskNot4, MskNot5, MskNot6, MskNotTotal);
        }   

        private void MskTotVfr4_Leave(object sender, EventArgs e)
        {
            CalculadoraVfrDiu(MskTotVfr4, MskVfr4);
            CalculadoraIfrNot(MskVoo4, MskVfr4, MskIfr4);
            CalculoTotais4(MskIfr1, MskIfr2, MskIfr3, MskIfr4, MskIfr5, MskIfr6, MskIfrTotal);
            CalculoTotais4(MskVfr1, MskVfr2, MskVfr3, MskVfr4, MskVfr5, MskVfr6, MskVfrTotal);
        }

        private void MskTotNoturno4_Leave(object sender, EventArgs e)
        {
            CalculadoraVfrDiu(MskTotNoturno4, MskNot4);
            CalculadoraIfrNot(MskVoo4, MskNot4, MskDiu4);
            CalculoTotais4(MskDiu1, MskDiu2, MskDiu3, MskDiu4, MskDiu5, MskDiu6, MskDiuTotal);
            CalculoTotais4(MskNot1, MskNot2, MskNot3, MskNot4, MskNot5, MskNot6, MskNotTotal);
        }    

        private void MskTotVfr5_Leave(object sender, EventArgs e)
        {
            CalculadoraVfrDiu(MskTotVfr5, MskVfr5);
            CalculadoraIfrNot(MskVoo5, MskVfr5, MskIfr5);
            CalculoTotais5(MskIfr1, MskIfr2, MskIfr3, MskIfr4, MskIfr5, MskIfr6, MskIfrTotal);
            CalculoTotais5(MskVfr1, MskVfr2, MskVfr3, MskVfr4, MskVfr5, MskVfr6, MskVfrTotal);
        }

        private void MskTotNoturno5_Leave(object sender, EventArgs e)
        {
            CalculadoraVfrDiu(MskTotNoturno5, MskNot5);
            CalculadoraIfrNot(MskVoo5, MskNot5, MskDiu5);
            CalculoTotais5(MskDiu1, MskDiu2, MskDiu3, MskDiu4, MskDiu5, MskDiu6, MskDiuTotal);
            CalculoTotais5(MskNot1, MskNot2, MskNot3, MskNot4, MskNot5, MskNot6, MskNotTotal);
        }  

        private void MskTotVfr6_Leave(object sender, EventArgs e)
        {
            CalculadoraVfrDiu(MskTotVfr6, MskVfr6);
            CalculadoraIfrNot(MskVoo6, MskVfr6, MskIfr6);
            CalculoTotais6(MskIfr1, MskIfr2, MskIfr3, MskIfr4, MskIfr5, MskIfr6, MskIfrTotal);
            CalculoTotais6(MskVfr1, MskVfr2, MskVfr3, MskVfr4, MskVfr5, MskVfr6, MskVfrTotal);
        }

        private void MskTotNoturno6_Leave(object sender, EventArgs e)
        {
            CalculadoraVfrDiu(MskTotNoturno3, MskNot3);
            CalculadoraIfrNot(MskVoo3, MskNot3, MskDiu3);
            CalculoTotais6(MskDiu1, MskDiu2, MskDiu3, MskDiu4, MskDiu5, MskDiu6, MskDiuTotal);
            CalculoTotais6(MskNot1, MskNot2, MskNot3, MskNot4, MskNot5, MskNot6, MskNotTotal);
        }

        private void CalculoCiclosPousos1(MaskedTextBox cpTotal1, MaskedTextBox cpTotal2, MaskedTextBox cpTotal3, MaskedTextBox cpTotal4, MaskedTextBox cpTotal5, MaskedTextBox cpTotal6, MaskedTextBox cpTotalTotal)
        {
            int total1 = int.Parse(cpTotal1.Text.Trim());
            int total2 = 0;
            int total3 = 0;
            int total4 = 0;
            int total5 = 0;
            int total6 = 0;

            if (int.TryParse(cpTotal2.Text, out int resultado2)) total2 = resultado2;
            if (int.TryParse(cpTotal3.Text, out int resultado3)) total3 = resultado3;
            if (int.TryParse(cpTotal4.Text, out int resultado4)) total4 = resultado4;
            if (int.TryParse(cpTotal5.Text, out int resultado5)) total5 = resultado5;
            if (int.TryParse(cpTotal6.Text, out int resultado6)) total6 = resultado6;

            int somaTotal = total1 + total2 + total3 + total4 + total5 + total6;
            cpTotalTotal.Text = somaTotal.ToString();
        }

        private void CalculoCiclosPousos2(MaskedTextBox cpTotal1, MaskedTextBox cpTotal2, MaskedTextBox cpTotal3, MaskedTextBox cpTotal4, MaskedTextBox cpTotal5, MaskedTextBox cpTotal6, MaskedTextBox cpTotalTotal)
        {
            int total1 = int.Parse(cpTotal1.Text.Trim());
            int total2 = int.Parse(cpTotal2.Text.Trim());
            int total3 = 0;
            int total4 = 0;
            int total5 = 0;
            int total6 = 0;

            if (int.TryParse(cpTotal3.Text, out int resultado3)) total3 = resultado3;
            if (int.TryParse(cpTotal4.Text, out int resultado4)) total4 = resultado4;
            if (int.TryParse(cpTotal5.Text, out int resultado5)) total5 = resultado5;
            if (int.TryParse(cpTotal6.Text, out int resultado6)) total6 = resultado6;

            int somaTotal = total1 + total2 + total3 + total4 + total5 + total6;
            cpTotalTotal.Text = somaTotal.ToString();
        }

        private void CalculoCiclosPousos3(MaskedTextBox cpTotal1, MaskedTextBox cpTotal2, MaskedTextBox cpTotal3, MaskedTextBox cpTotal4, MaskedTextBox cpTotal5, MaskedTextBox cpTotal6, MaskedTextBox cpTotalTotal)
        {
            int total1 = int.Parse(cpTotal1.Text.Trim());
            int total2 = int.Parse(cpTotal2.Text.Trim());
            int total3 = int.Parse(cpTotal3.Text.Trim());
            int total4 = 0;
            int total5 = 0;
            int total6 = 0;

            if (int.TryParse(cpTotal4.Text, out int resultado4)) total4 = resultado4;
            if (int.TryParse(cpTotal5.Text, out int resultado5)) total5 = resultado5;
            if (int.TryParse(cpTotal6.Text, out int resultado6)) total6 = resultado6;

            int somaTotal = total1 + total2 + total3 + total4 + total5 + total6;
            cpTotalTotal.Text = somaTotal.ToString();
        }

        private void CalculoCiclosPousos4(MaskedTextBox cpTotal1, MaskedTextBox cpTotal2, MaskedTextBox cpTotal3, MaskedTextBox cpTotal4, MaskedTextBox cpTotal5, MaskedTextBox cpTotal6, MaskedTextBox cpTotalTotal)
        {
            int total1 = int.Parse(cpTotal1.Text.Trim());
            int total2 = int.Parse(cpTotal2.Text.Trim());
            int total3 = int.Parse(cpTotal3.Text.Trim());
            int total4 = int.Parse(cpTotal4.Text.Trim());
            int total5 = 0;
            int total6 = 0;

            if (int.TryParse(cpTotal5.Text, out int resultado5)) total5 = resultado5;
            if (int.TryParse(cpTotal6.Text, out int resultado6)) total6 = resultado6;

            int somaTotal = total1 + total2 + total3 + total4 + total5 + total6;
            cpTotalTotal.Text = somaTotal.ToString();
        }

        private void CalculoCiclosPousos5(MaskedTextBox cpTotal1, MaskedTextBox cpTotal2, MaskedTextBox cpTotal3, MaskedTextBox cpTotal4, MaskedTextBox cpTotal5, MaskedTextBox cpTotal6, MaskedTextBox cpTotalTotal)
        {
            int total1 = int.Parse(cpTotal1.Text.Trim());
            int total2 = int.Parse(cpTotal2.Text.Trim());
            int total3 = int.Parse(cpTotal3.Text.Trim());
            int total4 = int.Parse(cpTotal4.Text.Trim());
            int total5 = int.Parse(cpTotal5.Text.Trim());
            int total6 = 0;

            if (int.TryParse(cpTotal6.Text, out int resultado6)) total6 = resultado6;

            int somaTotal = total1 + total2 + total3 + total4 + total5 + total6;
            cpTotalTotal.Text = somaTotal.ToString();
        }

        private void CalculoCiclosPousos6(MaskedTextBox cpTotal1, MaskedTextBox cpTotal2, MaskedTextBox cpTotal3, MaskedTextBox cpTotal4, MaskedTextBox cpTotal5, MaskedTextBox cpTotal6, MaskedTextBox cpTotalTotal)
        {
            int total1 = int.Parse(cpTotal1.Text.Trim());
            int total2 = int.Parse(cpTotal2.Text.Trim());
            int total3 = int.Parse(cpTotal3.Text.Trim());
            int total4 = int.Parse(cpTotal4.Text.Trim());
            int total5 = int.Parse(cpTotal5.Text.Trim());
            int total6 = int.Parse(cpTotal6.Text.Trim());

            int somaTotal = total1 + total2 + total3 + total4 + total5 + total6;
            cpTotalTotal.Text = somaTotal.ToString();
        }

        private void MskCiclos1_Leave(object sender, EventArgs e)
        {
            CalculoCiclosPousos1(MskCiclos1, MskCiclos2, MskCiclos3, MskCiclos4, MskCiclos5, MskCiclos6, MskSomaCiclos);

            var ciclosAnt = int.Parse(MskCiclosAnteriores.Text);
            var ciclosVoo = int.Parse(MskSomaCiclos.Text);
            int ciclosTotais = ciclosAnt + ciclosVoo;
            MskCiclosTotais.Text = ciclosTotais.ToString();
        }

        private void MskCiclos2_Leave(object sender, EventArgs e)
        {
            CalculoCiclosPousos2(MskCiclos1, MskCiclos2, MskCiclos3, MskCiclos4, MskCiclos5, MskCiclos6, MskSomaCiclos);

            var ciclosAnt = int.Parse(MskCiclosAnteriores.Text);
            var ciclosVoo = int.Parse(MskSomaCiclos.Text);
            int ciclosTotais = ciclosAnt + ciclosVoo;
            MskCiclosTotais.Text = ciclosTotais.ToString();
        }

        private void MskCiclos3_Leave(object sender, EventArgs e)
        {
            CalculoCiclosPousos3(MskCiclos1, MskCiclos2, MskCiclos3, MskCiclos4, MskCiclos5, MskCiclos6, MskSomaCiclos);

            var ciclosAnt = int.Parse(MskCiclosAnteriores.Text);
            var ciclosVoo = int.Parse(MskSomaCiclos.Text);
            int ciclosTotais = ciclosAnt + ciclosVoo;
            MskCiclosTotais.Text = ciclosTotais.ToString();
        }

        private void MskCiclos4_Leave(object sender, EventArgs e)
        {
            CalculoCiclosPousos4(MskCiclos1, MskCiclos2, MskCiclos3, MskCiclos4, MskCiclos5, MskCiclos6, MskSomaCiclos);

            var ciclosAnt = int.Parse(MskCiclosAnteriores.Text);
            var ciclosVoo = int.Parse(MskSomaCiclos.Text);
            int ciclosTotais = ciclosAnt + ciclosVoo;
            MskCiclosTotais.Text = ciclosTotais.ToString();
        }

        private void MskCiclos5_Leave(object sender, EventArgs e)
        {
            CalculoCiclosPousos5(MskCiclos1, MskCiclos2, MskCiclos3, MskCiclos4, MskCiclos5, MskCiclos6, MskSomaCiclos);

            var ciclosAnt = int.Parse(MskCiclosAnteriores.Text);
            var ciclosVoo = int.Parse(MskSomaCiclos.Text);
            int ciclosTotais = ciclosAnt + ciclosVoo;
            MskCiclosTotais.Text = ciclosTotais.ToString();
        }

        private void MskCiclos6_Leave(object sender, EventArgs e)
        {
            CalculoCiclosPousos6(MskCiclos1, MskCiclos2, MskCiclos3, MskCiclos4, MskCiclos5, MskCiclos6, MskSomaCiclos);

            var ciclosAnt = int.Parse(MskCiclosAnteriores.Text);
            var ciclosVoo = int.Parse(MskSomaCiclos.Text);
            int ciclosTotais = ciclosAnt + ciclosVoo;
            MskCiclosTotais.Text = ciclosTotais.ToString();
        }

        private void MskPousos1_Leave(object sender, EventArgs e)
        {
            CalculoCiclosPousos1(MskPousos1, MskPousos2, MskPousos3, MskPousos4, MskPousos5, MskPousos6, MskSomaPousos);

            var pousosAnt = int.Parse(MskPousosAnteriores.Text);
            var pousosVoo = int.Parse(MskSomaPousos.Text);
            int pousosTotais = pousosAnt + pousosVoo;
            MskPousosTotais.Text = pousosTotais.ToString();
        }

        private void MskPousos2_Leave(object sender, EventArgs e)
        {
            CalculoCiclosPousos2(MskPousos1, MskPousos2, MskPousos3, MskPousos4, MskPousos5, MskPousos6, MskSomaPousos);

            var pousosAnt = int.Parse(MskPousosAnteriores.Text);
            var pousosVoo = int.Parse(MskSomaPousos.Text);
            int pousosTotais = pousosAnt + pousosVoo;
            MskPousosTotais.Text = pousosTotais.ToString();
        }

        private void MskPousos3_Leave(object sender, EventArgs e)
        {
            CalculoCiclosPousos3(MskPousos1, MskPousos2, MskPousos3, MskPousos4, MskPousos5, MskPousos6, MskSomaPousos);

            var pousosAnt = int.Parse(MskPousosAnteriores.Text);
            var pousosVoo = int.Parse(MskSomaPousos.Text);
            int pousosTotais = pousosAnt + pousosVoo;
            MskPousosTotais.Text = pousosTotais.ToString();
        }

        private void MskPousos4_Leave(object sender, EventArgs e)
        {
            CalculoCiclosPousos4(MskPousos1, MskPousos2, MskPousos3, MskPousos4, MskPousos5, MskPousos6, MskSomaPousos);

            var pousosAnt = int.Parse(MskPousosAnteriores.Text);
            var pousosVoo = int.Parse(MskSomaPousos.Text);
            int pousosTotais = pousosAnt + pousosVoo;
            MskPousosTotais.Text = pousosTotais.ToString();
        }

        private void MskPousos5_Leave(object sender, EventArgs e)
        {
            CalculoCiclosPousos5(MskPousos1, MskPousos2, MskPousos3, MskPousos4, MskPousos5, MskPousos6, MskSomaPousos);

            var pousosAnt = int.Parse(MskPousosAnteriores.Text);
            var pousosVoo = int.Parse(MskSomaPousos.Text);
            int pousosTotais = pousosAnt + pousosVoo;
            MskPousosTotais.Text = pousosTotais.ToString();
        }

        private void MskPousos6_Leave(object sender, EventArgs e)
        {
            CalculoCiclosPousos6(MskPousos1, MskPousos2, MskPousos3, MskPousos4, MskPousos5, MskPousos6, MskSomaPousos);

            var pousosAnt = int.Parse(MskPousosAnteriores.Text);
            var pousosVoo = int.Parse(MskSomaPousos.Text);
            int pousosTotais = pousosAnt + pousosVoo;
            MskPousosTotais.Text = pousosTotais.ToString();
        }

        private void MskCombEt1_Leave(object sender, EventArgs e)
        {
            int combPartida1 = int.Parse(MskCombPart1.Text);
            int combEtapa1 = int.Parse(MskCombEt1.Text);
            int combRem1 = combPartida1 - combEtapa1;
            MskCombRem1.Text = combRem1.ToString();
        }

        private void MskCombEt2_Leave(object sender, EventArgs e)
        {
            int combPartida2 = int.Parse(MskCombPart2.Text);
            int combEtapa2 = int.Parse(MskCombEt2.Text);
            int combRem2 = combPartida2 - combEtapa2;
            MskCombRem2.Text = combRem2.ToString();
        }

        private void MskCombEt3_Leave(object sender, EventArgs e)
        {
            int combPartida3 = int.Parse(MskCombPart3.Text);
            int combEtapa3 = int.Parse(MskCombEt3.Text);
            int combRem3 = combPartida3 - combEtapa3;
            MskCombRem3.Text = combRem3.ToString();
        }

        private void MskCombEt4_Leave(object sender, EventArgs e)
        {
            int combPartida4 = int.Parse(MskCombPart4.Text);
            int combEtapa4 = int.Parse(MskCombEt4.Text);
            int combRem4 = combPartida4 - combEtapa4;
            MskCombRem4.Text = combRem4.ToString();
        }

        private void MskCombEt5_Leave(object sender, EventArgs e)
        {
            int combPartida5 = int.Parse(MskCombPart5.Text);
            int combEtapa5 = int.Parse(MskCombEt5.Text);
            int combRem5 = combPartida5 - combEtapa5;
            MskCombRem5.Text = combRem5.ToString();
        }

        private void MskCombEt6_Leave(object sender, EventArgs e)
        {
            int combPartida6 = int.Parse(MskCombPart6.Text);
            int combEtapa6 = int.Parse(MskCombEt6.Text);
            int combRem6 = combPartida6 - combEtapa6;
            MskCombRem6.Text = combRem6.ToString();
        }

        private void MskDe1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar)) e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void MskPara1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar)) e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void MskDe2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar)) e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void MskPara2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar)) e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void MskDe3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar)) e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void MskPara3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar)) e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void MskDe4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar)) e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void MskPara4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar)) e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void MskDe5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar)) e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void MskPara5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar)) e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void MskDe6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar)) e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void MskPara6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar)) e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void DtpData_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Logbook_Load(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void listBox5_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void listBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox10_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox17_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox18_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox19_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox20_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox21_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox22_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 segundoFormulario = new Form1();
            segundoFormulario.Show();
        }

        private void maskedTextBox128_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void MskCombRem1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void MskCiclos6_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }              

        private void maskedTextBox75_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void MskTotVfr4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox88_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox89_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox106_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void MskCiclos5_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox171_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
                                                                  
        }              

        private void MskSomaPousos_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void MskVooTotal_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void MskNot1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void MskTotal4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox74_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox91_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox72_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox54_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void MskTotVfr2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void MskHorasTotais_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void maskedTextBox9_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox31_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void MskVfrTotal_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void MskTotalTotal_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }             
    
    private void MskDe6_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

    }

}
