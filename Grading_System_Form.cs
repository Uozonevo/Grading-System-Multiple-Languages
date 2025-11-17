using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metric_Conversion_Forms
{
  public partial class Form_Frontend: Form
  {
    public Form_Frontend()
    {
      initializeComponent();
    }
    
    private void button1_Click(object sender, EventArgs e)
    {
      double homework, quizzes, projects, exams, final, totalGrade;
      // Read Inputs
      homework = Convert.ToDouble(textBox2.Text);
      quizzes = Convert.ToDouble(textBox3.Text);
      projects = Convert.ToDouble(textBox5.Text);
      exams = Convert.ToDouble(textBox4.Text);
      final = Convert.ToDouble(textBox1.Text);
      // Process
      totalGrade = (0.1 * homework) + (0.2 * quizzes) +
                    (0.25 * projects) + (0.2 * exams) +
                    (0.25 * final);
      // Output
      textBox6.Text = Convert.ToString(totalGrade);
    }
  }
}
