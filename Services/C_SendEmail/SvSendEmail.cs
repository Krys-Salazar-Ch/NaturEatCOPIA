using Entities;
using Services.C_SendEmail;
using System.Net.Mail;
using System.Net;

public class SvSendEmail : ISvSendEmail
{
    public void SendEmail(Order_Confirmation order_Confirmation)
    {
        MailAddress addressFrom = new MailAddress("ecommerce.natureat@gmail.com", "NaturEat");
        MailAddress addressTo = new MailAddress(order_Confirmation.Customer.eMail);
        MailMessage message = new MailMessage(addressFrom, addressTo);
        message.Subject = "Confirmación de Orden";
        message.IsBodyHtml = true;
        message.Body = GenerateEmailBody(order_Confirmation);

        SmtpClient client = new SmtpClient("smtp.gmail.com");
        client.Port = 587;
        client.EnableSsl = true;
        client.UseDefaultCredentials = false;
        client.Credentials = new NetworkCredential("ecommerce.natureat@gmail.com", "auzs nlie edsi vczl");
        try
        {
            client.Send(message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }

    private string GenerateEmailBody(Order_Confirmation order_Confirmation)
    {
        string emailBody = $@"
            <html>
          <body>
 <h1 style=""font-family: 'Times New Roman', serif; color: black;"">Confirmación de Orden</h1>
 <font size=""4""><p style=""font-family: 'Times New Roman', serif; color: black;""><strong>Fecha Emisión:</strong> {order_Confirmation.Date}</p> </font>               
 <font size=""4""><p style=""font-family: 'Times New Roman', serif; color: black;""><strong>Orden Número:</strong> {order_Confirmation.Id}</p><br></font> 
               
 <font size=""4""><p style=""font-family: 'Times New Roman', serif; color: black;""><strong>Cliente:</strong> {order_Confirmation.Customer.Name}</p>  </font>               
<font size=""4""> <p style=""font-family: 'Times New Roman', serif; color: black;""><strong>Número telefónico:</strong> {order_Confirmation.Customer.Phone_Number}</p></font> 
            
<font size=""4""><p style=""font-family: 'Times New Roman', serif; color: black;""><strong>Correo electrónico:</strong> {order_Confirmation.Customer.eMail}</p><br> </font>                

<h2 style=""font-family: 'Times New Roman', serif; color: black;"">Resumen de la orden:</h2>
              
                <table border='0' cellspacing='0' style='border-collapse: collapse; width: 100%;'>
                  <tr>
                      <th bgcolor='#f0f0f0' style='border: 1.2px solid #ccc;padding: 10px; font-family: Times New Roman, serif; color: black;  text-align: center;'>Producto</th>
                     <th bgcolor='#f0f0f0' style='border: 1.2px solid #ccc;padding: 10px; font-family: Times New Roman, serif; color: black;  text-align: center;'>Catidad</th>
                     <th bgcolor='#f0f0f0' style='border: 1.2px solid #ccc;padding: 10px; font-family: Times New Roman, serif; color: black;  text-align: center;'>Precio Unitario</th>
                  </tr>";

        foreach (var orderDetail in order_Confirmation.OrderDetails)
        {
            emailBody += $@"
        <tr>
            <td bgcolor='#f7f7f7' style='border: 1.2px solid #ccc; padding: 10px; font-family: Times New Roman, serif; color: black; text-align: left; '>{orderDetail.Product.Name}</td>
            <td bgcolor='#f7f7f7' style='border: 1.2px solid #ccc; padding: 10px; font-family: Times New Roman, serif; color: black; text-align: left; '>{orderDetail.Quantity}</td>
            <td bgcolor='#f7f7f7' style='border: 1.2px solid #ccc; padding: 10px; font-family: Times New Roman, serif; color: black; text-align: left; '>₡{orderDetail.Product.Price}</td>
        </tr>";
        }


        emailBody += $@"
                 <tr class='totals-row' style=""text-align: left;"">
            <td colspan='2'></td>
           <td style= ""font-family: Times New Roman, serif; color: black;""><strong>Subtotal: </strong>₡{order_Confirmation.SubTotal}</td>
        </tr>

                <tr class='totals-row' style=""text-align: left;"">
            <td colspan='2'></td>
            <td style= ""font-family: Times New Roman, serif; color: black;""><strong>IVA: </strong>₡₡{order_Confirmation.IVA}</td>
        </tr>

                <tr class='totals-row' style=""text-align: left;"">
            <td colspan='2'></td>
            <td style= ""font-family: Times New Roman, serif; color: black;""><strong>Total:</strong> ₡{order_Confirmation.Total}</td>
        </tr>

            </table><br><br>
            <h2 style=""font-family: Times New Roman, serif; color: black;"">¡Gracias por su compra!</h2>
                 </body>
              </html>";

        return emailBody;
    }


}