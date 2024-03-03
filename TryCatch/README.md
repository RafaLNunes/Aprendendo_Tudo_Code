# TryCatch

Try: funciona para efetuar um código que pode dar ero

catch: faz a mensagem do erro sem fechar o código

´´´
try
{
	int v1 = 10;
	int v2 = 0;
	int calc = v1/v2;
	MessageBox.Show(calc);

}catch (Exception ex)
{
	MessageBox.Show("Erro: " + ex.message);
}
´´´

dependendo do caso podendo usar o finally depois do catch para finalizar o código

´´´
finally
{
        MessageBox.Show("Código Finalizado");
	Close();
}
´´´
