using System.Globalization;

string dataString = "2023-10-15 15:00";

DateTime.TryParseExact
(
    dataString, 
    "yyyy-MM-dd HH:mm",
    CultureInfo.InvariantCulture,
    DateTimeStyles.None,
    out DateTime data
);

Console.WriteLine(data);



// DateTime data = DateTime.Now;

// Console.WriteLine(data.ToShortTimeString());

// Console.WriteLine(data.ToString("dd/MM/yy HH:mm"));



// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
// decimal valorMonetario = 1582.40M;

// Console.WriteLine(valorMonetario.ToString("C5"));

// double porcentagem = .3421;

// Console.WriteLine(porcentagem.ToString("P"));

// int numero = 123456;
// Console.WriteLine(numero.ToString("##-##-##"));




// string numero1 = "10";
// string numero2 = "20";

// string resultado = numero1 + numero2;

// Console.WriteLine(resultado);
