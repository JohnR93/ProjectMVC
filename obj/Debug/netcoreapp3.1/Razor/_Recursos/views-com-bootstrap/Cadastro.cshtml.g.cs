#pragma checksum "C:\Users\TORRE 01\source\repos\ProjectMVC\ProjectMVC\_Recursos\views-com-bootstrap\Cadastro.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "849f452952a165aa9d6eb7947f959ef4f618c48d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore._Recursos_views_com_bootstrap_Cadastro), @"mvc.1.0.view", @"/_Recursos/views-com-bootstrap/Cadastro.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"849f452952a165aa9d6eb7947f959ef4f618c48d", @"/_Recursos/views-com-bootstrap/Cadastro.cshtml")]
    public class _Recursos_views_com_bootstrap_Cadastro : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<h3>Cadastro</h3>

<div class=""panel panel-default"">
    <div class=""panel-body"">
        <div class=""col-md-4"">
            <div class=""form-group"">
                <label class=""control-label"" for=""nomeCliente"">Nome do Cliente</label>
                <input type=""text"" class=""form-control"" id=""nomeCliente"" placeholder=""Nome do Cliente"">
            </div>
            <div class=""form-group"">
                <label class=""control-label"" for=""email"">Email</label>
                <input type=""email"" class=""form-control"" id=""email"" placeholder=""Email"">
            </div>
            <div class=""form-group"">
                <label class=""control-label"" for=""telefone"">Telefone</label>
                <input type=""text"" class=""form-control"" id=""telefone"" placeholder=""Telefone"">
            </div>
        </div>
        <div class=""col-md-4"">
            <div class=""form-group"">
                <label class=""control-label"" for=""endereco"">Endereço</label>
                <input type=""text"" class=""form-control"" id=""e");
            WriteLiteral(@"ndereco"" placeholder=""Endereço"">
            </div>
            <div class=""form-group"">
                <label class=""control-label"" for=""complemento"">Complemento</label>
                <input type=""text"" class=""form-control"" id=""complemento"" placeholder=""Complemento"">
            </div>
            <div class=""form-group"">
                <label class=""control-label"" for=""bairro"">Bairro</label>
                <input type=""text"" class=""form-control"" id=""bairro"" placeholder=""Bairro"">
            </div>
        </div>
        <div class=""col-md-4"">
            <div class=""form-group"">
                <label class=""control-label"" for=""municipio"">Município</label>
                <input type=""text"" class=""form-control"" id=""municipio"" placeholder=""Município"">
            </div>
            <div class=""form-group"">
                <label class=""control-label"" for=""UF"">UF</label>
                <select class=""form-control single-select"" name=""UF"">
                    <option selected");
            BeginWriteAttribute("value", " value=\"", 2019, "\"", 2027, 0);
            EndWriteAttribute();
            WriteLiteral(@">[Selecione o estado]</option>
                    <option value=""AC"">Acre</option>
                    <option value=""AL"">Alagoas</option>
                    <option value=""AP"">Amapá</option>
                    <option value=""AM"">Amazonas</option>
                    <option value=""BA"">Bahia</option>
                    <option value=""CE"">Ceará</option>
                    <option value=""DF"">Distrito Federal</option>
                    <option value=""ES"">Espírito Santo</option>
                    <option value=""GO"">Goiás</option>
                    <option value=""MA"">Maranhão</option>
                    <option value=""MT"">Mato Grosso</option>
                    <option value=""MS"">Mato Grosso do Sul</option>
                    <option value=""MG"">Minas Gerais</option>
                    <option value=""PA"">Pará</option>
                    <option value=""PB"">Paraíba</option>
                    <option value=""PR"">Paraná</option>
                    <option value=""PE"">Pernambuco</option>
               ");
            WriteLiteral(@"     <option value=""PI"">Piauí</option>
                    <option value=""RJ"">Rio de Janeiro</option>
                    <option value=""RN"">Rio Grande do Norte</option>
                    <option value=""RS"">Rio Grande do Sul</option>
                    <option value=""RO"">Rondônia</option>
                    <option value=""RR"">Roraima</option>
                    <option value=""SC"">Santa Catarina</option>
                    <option value=""SP"">São Paulo</option>
                    <option value=""SE"">Sergipe</option>
                    <option value=""TO"">Tocantins</option>
                </select>
            </div>
            <div class=""form-group"">
                <label class=""control-label"" for=""cep"">CEP</label>
                <input type=""text"" class=""form-control"" id=""cep"" placeholder=""CEP"">
            </div>

            <div class=""form-group"">
                <a class=""btn btn-success"" href=""/"">
                    Continuar Comprando
                </a>
            </div>
            <div ");
            WriteLiteral("class=\"form-group\">\n                <button type=\"submit\"\n                        class=\"btn btn-success\">\n                    Finalizar Pedido\n                </button>\n            </div>\n        </div>\n    </div>\n</div>\n");
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
