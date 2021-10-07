using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      int[] posXAtacada=new int[80], posYAtacada=new int[80];
      int auxPosAtacadaH = 0, auxPosAtacadaV, existe = 0,auxPos=6,tamano=6;
      int[] posX = new int[] { 0, 0, 1, 1, 1, 2, 2, 2, 2, 2, 3, 3, 3, 3, 4, 4, 4, 5, 5, 5 };

      int[] posY = new int[] { 3, 5, 0, 2, 4, 0, 2, 3, 4, 5, 2, 3, 4, 5, 0, 1, 3, 0, 1, 2 };
for(int i=0;i<auxPos;i++) 
{
  existe=0;  
   for(int j=0;j<tamano;j++)  //Ataque Horizontal
   {
     for(int z=0;z<auxPosAtacadaH;z++)
     {
       if(posXAtacada[z]==posX[i] && posYAtacada[z]==j)
       {
            existe=1;  
            break;
       }
} 
     if(existe==0)
     {
        posXAtacada[auxPosAtacadaH]=posX[i];
        posYAtacada[auxPosAtacadaH]=j;
//        printf("Atacada Horizontal %d,%d", posXAtacada[auxPosAtacadaH], posYAtacada[auxPosAtacadaH]);
//printf("\n");
auxPosAtacadaH=auxPosAtacadaH+1;
     }
     if(existe==1)
        existe=0;
   }
    existe=0;
   for(int k=0;k<tamano;k++) //Ataque Vertical
   {
        for(int z=0;z<auxPosAtacadaH;z++)
            { 
                if(posXAtacada[z]==k && posYAtacada[z]==posY[i])
                    {
                        existe=1;  
                        break;
                    }
            }        
        if(existe==0)
        {
            posXAtacada[auxPosAtacadaH]=k;
            posYAtacada[auxPosAtacadaH]=posY[i];
//            printf("Atacada Vertical %d,%d", posXAtacada[auxPosAtacadaH], posYAtacada[auxPosAtacadaH]);
//printf("\n");
auxPosAtacadaH=auxPosAtacadaH+1;
        } 
         if(existe==1)
        existe=0;
    }
 }

    }
  }
}
