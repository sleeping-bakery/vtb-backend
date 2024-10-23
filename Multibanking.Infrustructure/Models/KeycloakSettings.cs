namespace Multibanking.Infrustructure.Models;

public class KeycloakSettings
{
    public string? Authority { get; set; }
    public string? ValidAudience { get; set; }
    public string? ValidIssuer { get; set; }
    public string? CertificateUrl { get; set; }
}