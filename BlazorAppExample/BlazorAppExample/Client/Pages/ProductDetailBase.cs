using Microsoft.AspNetCore.Components;

namespace BlazorAppExample.Client
{
    public class ProductDetailBase : ComponentBase
    {
        public string headingFontStyle { get; set; } = "italic";

        public string headingText {get; set; } = "Detalhes do Produto";
    }
}