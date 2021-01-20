#pragma checksum "C:\Users\TORRE 01\source\repos\ProjectMVC\ProjectMVC\_Recursos\views-com-bootstrap\Carrinho.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a593df0bcdc287de7dcf17dd8bced0172b2b9772"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore._Recursos_views_com_bootstrap_Carrinho), @"mvc.1.0.view", @"/_Recursos/views-com-bootstrap/Carrinho.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a593df0bcdc287de7dcf17dd8bced0172b2b9772", @"/_Recursos/views-com-bootstrap/Carrinho.cshtml")]
    public class _Recursos_views_com_bootstrap_Carrinho : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<h3>Meu Carrinho</h3>

<div class=""panel panel-default"">
    <div class=""panel-heading"">

        <div class=""row"">
            <div class=""col-md-6"">
                Item
            </div>
            <div class=""col-md-2 text-center"">
                Preço Unitário
            </div>
            <div class=""col-md-2 text-center"">
                Quantidade
            </div>
            <div class=""col-md-2"">
                <span class=""pull-right"">
                    Subtotal
                </span>
            </div>
        </div>
    </div>
    <div class=""panel-body"">
        <div class=""row row-center linha-produto"">
            <div class=""col-md-3"">
                <img class=""img-produto-carrinho"" src=""/images/produtos/large_047.jpg"" />
            </div>
            <div class=""col-md-3"">Arduino Pr&#xE1;tico</div>
            <div class=""col-md-2 text-center"">R$ 69,90</div>
            <div class=""col-md-2 text-center"">
                <div class=""input-group"">
                    <span class=""");
            WriteLiteral(@"input-group-btn"">
                        <button class=""btn btn-default"">
                            <span class=""glyphicon-minus""></span>
                        </button>
                    </span>
                    <input type=""text"" value=""2""
                           class=""form-control text-center"" />
                    <span class=""input-group-btn"">
                        <button class=""btn btn-default"">
                            <span class=""glyphicon-plus""></span>
                        </button>
                    </span>
                </div>
            </div>
            <div class=""col-md-2"">
                R$ <span class=""pull-right"" subtotal>
                    139,80
                </span>
            </div>
        </div>
        <div class=""row row-center linha-produto"">
            <div class=""col-md-3"">
                <img class=""img-produto-carrinho"" src=""/images/produtos/large_035.jpg"" />
            </div>
            <div class=""col-md-3"">PostgreSQL</div>
            ");
            WriteLiteral(@"<div class=""col-md-2 text-center"">R$ 69,90</div>
            <div class=""col-md-2 text-center"">
                <div class=""input-group"">
                    <span class=""input-group-btn"">
                        <button class=""btn btn-default"">
                            <span class=""glyphicon-minus""></span>
                        </button>
                    </span>
                    <input type=""text"" value=""3""
                           class=""form-control text-center"" />
                    <span class=""input-group-btn"">
                        <button class=""btn btn-default"">
                            <span class=""glyphicon-plus""></span>
                        </button>
                    </span>
                </div>
            </div>
            <div class=""col-md-2"">
                R$ <span class=""pull-right"" subtotal>
                    209,70
                </span>
            </div>
        </div>
        <div class=""row row-center linha-produto"">
            <div class=""col-md-3"">
 ");
            WriteLiteral(@"               <img class=""img-produto-carrinho"" src=""/images/produtos/large_042.jpg"" />
            </div>
            <div class=""col-md-3"">Scala</div>
            <div class=""col-md-2 text-center"">R$ 69,90</div>
            <div class=""col-md-2 text-center"">
                <div class=""input-group"">
                    <span class=""input-group-btn"">
                        <button class=""btn btn-default"">
                            <span class=""glyphicon-minus""></span>
                        </button>
                    </span>
                    <input type=""text"" value=""1""
                           class=""form-control text-center"" />
                    <span class=""input-group-btn"">
                        <button class=""btn btn-default"">
                            <span class=""glyphicon-plus""></span>
                        </button>
                    </span>
                </div>
            </div>
            <div class=""col-md-2"">
                R$ <span class=""pull-right"" subtotal>
      ");
            WriteLiteral(@"              69,90
                </span>
            </div>
        </div>
    </div>
    <div class=""panel-footer"">
        <div class=""row"">
            <div class=""col-md-10"">
                <span numero-itens>
                    Total: 3
                    itens
                </span>
            </div>
            <div class=""col-md-2"">
                Total: R$ <span class=""pull-right"" total>
                    419,40
                </span>
            </div>
        </div>
    </div>
</div>

<div class=""row"">
    <div class=""col-md-12"">
        <div class=""pull-right"">
            <a class=""btn btn-success"" href=""/"">
                Adicionar Produtos
            </a>
            <a class=""btn btn-success"" href=""/"">
                Preencher Cadastro
            </a>
        </div>
    </div>
</div>
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591