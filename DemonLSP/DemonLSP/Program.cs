using DemonLSP;

Pago_con_Reembolso P1 = new Tarjeta("juan", 2000);
P1.procesarpago();
P1.Reembolsar();

/* 
    P1 al pertencer a Trajeta, tambien puede pertenecer a 
    Transferencia, por el buen uso del LSP
*/
P1 = new Transferencia("Pedro", 5000);
P1.procesarpago();
P1.Reembolsar();

Metodo_de_Pago P2 = new Efectivo("Lucas", 15000);
P2.procesarpago();
/*
   si intentamos hacer P2.Reembolsar(); nos saltaría error ya que la clase efectivo hereda de 
   la clase metodo de pago, la cual no posee un método abtracto que permita el reembolso, pero si a su vez
   intentamos P2 = new Transferencia("Pedro", 5000); el código funcionaría ya que transferencia es
   un medio de pago, mas no de reembolso por como fue creado P2.
*/