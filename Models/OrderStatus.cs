namespace ShopSystemAPI.Models;

public enum OrderStatus
{
    Pending,        // Bestellung eingegangen, aber noch nicht bearbeitet
    Processing,     // Bestellung wird bearbeitet
    Shipped,        // Bestellung wurde versandt
    Delivered,      // Bestellung wurde zugestellt
    Canceled,       // Bestellung wurde vom Kunden oder Shop storniert
    Returned,       // Bestellung wurde zurückgeschickt
    Refunded,       // Geld wurde an den Kunden zurückerstattet
    OnHold,         // Bestellung ist vorübergehend pausiert
    Failed,         // Zahlung fehlgeschlagen oder andere Probleme
    AwaitingPayment // Bestellung erwartet noch Zahlung
}
