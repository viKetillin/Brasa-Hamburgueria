var modalDetalheProduto = null;
var idFranquia = franquia;

$(document).ready(function () {
    modalDetalheProduto = new bootstrap.Modal(document.getElementById('modalDetalheProduto'), {
        keyboard: false
    });
});

function abrirModal(id) {
    $.ajax({
        url: urlApi + "ProdutoFranquia/recuperarAdicionais?idFranquia=" + parseInt(idFranquia),
        type: "GET",
        dataType: "json",
        success: function (result) {
            adicionais = result;
        },
        complete: function (errormessage) {
            pontoCarne(id);
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}

function pontoCarne(id) {
    $.ajax({
        url: urlApi + "PontoCarnes/recuperarPontosCarne",
        type: "GET",
        dataType: "json",
        success: function (result) {
            pontosCarne = result;
        },
        complete: function (errormessage) {
            detalheProduto(id);
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}

function detalheProduto(id) {
    $.ajax({
        url: urlApi + "ProdutoFranquia/recuperarProdutoId?idProduto=" + parseInt(id),
        type: "GET",
        dataType: "json",
        success: function (result) {
            var html = "";
            html += ' <div class="modal-header"> ';
            html += '     <h5 class="modal-title" id="exampleModalLabel">' + result.Produto.NomeProduto + '</h5> ';
            html += '     <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button> ';
            html += ' </div> ';
            html += ' <div class="modal-body"> ';
            html += '     <div class="divDescricaoLancheModal mb-3"> ';
            html += '         <img style="width: 100px;" src="' + result.Produto.ImagemProduto + '" /> ';
            html += '         <div id="descricaoLanche"> ' + result.Produto.DescricaoProduto + ' </div> ';
            html += '     </div> ';
            if (result.Produto.CategoriaId == 1) {
                html += '     <div class="accordion" id="accordionExample"> ';
                html += '         <div class="accordion-item"> ';
                html += '             <h2 class="accordion-header" id="headingPontoCarne"> ';
                html += '                 <button class="accordion-button" type="button" data-bs-toggle="collapse" data-bs-target="#collapsePontoCarne" aria-expanded="true" aria-controls="collapseIngredientes"> ';
                html += '         Ponto da carne ';
                html += '                 </button> ';
                html += '             </h2> ';
                html += '             <div id="collapsePontoCarne" class="accordion-collapse collapse show" aria-labelledby="headingPontoCarne" data-bs-parent="#accordionExample"> ';
                html += '                 <div class="accordion-body"> ';
                for (var i = 0; i < pontosCarne.length; i++) {
                    html += '                     <div class="form-check"> ';
                    html += '                         <input class="form-check-input" type="radio" name="pontoCarne" id="pontoCarne_' + pontosCarne[i].Id + '" checked /> ';
                    html += '                         <label class="form-check-label" for="pontoCarne_' + pontosCarne[i].Id + '"> ' + pontosCarne[i].NomePontoCarne + ' </label> ';
                    html += '                     </div> ';
                }
                html += '                 </div> ';
                html += '             </div> ';
                html += '         </div> ';
                html += '         <div class="accordion-item"> ';
                html += '             <h2 class="accordion-header" id="headingOne"> ';
                html += '                 <button class="accordion-button" type="button" data-bs-toggle="collapse" data-bs-target="#collapseIngredientes" aria-expanded="true" aria-controls="collapseIngredientes"> ';
                html += '         Ingredientes ';
                html += '                 </button> ';
                html += '             </h2> ';
                html += '             <div id="collapseIngredientes" class="accordion-collapse collapse show" aria-labelledby="headingOne" data-bs-parent="#accordionExample"> ';
                html += '                 <div class="accordion-body"> ';
                for (var i = 0; i < result.Produto.ProdutoIngredientes.length; i++) {
                    html += '                     <div class="form-check"> ';
                    html += '                         <input class="form-check-input ingrediente" type="checkbox" value="' + result.Produto.ProdutoIngredientes[i].Ingrediente.Id + '" id="ingrediente_' + i + '" checked="checked" /> ';
                    html += '                         <label class="form-check-label" for="flexCheckDefault"> ' + result.Produto.ProdutoIngredientes[i].Ingrediente.NomeIngrediente + '</label> ';
                    html += '                     </div> ';
                }
                html += '                 </div> ';
                html += '             </div> ';
                html += '         </div> ';
                html += '         <div class="accordion-item"> ';
                html += '             <h2 class="accordion-header" id="headingTwo"> ';
                html += '                 <button class="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#collapseAdicionais" aria-expanded="false" aria-controls="collapseAdicionais"> Adicionais </button> ';
                html += '             </h2> ';
                html += '             <div id="collapseAdicionais" class="accordion-collapse collapse" aria-labelledby="headingTwo" data-bs-parent="#accordionExample"> ';
                html += '                 <div class="accordion-body"> ';
                for (var i = 0; i < adicionais.length; i++) {
                    html += '                     <div class="form-check"> ';
                    html += '                         <input class="form-check-input adicional" type="checkbox" value="' + adicionais[i].Produto.Id + '" id="adicional_' + adicionais[i].Produto.Id + '" onchange="valorProduto(' + adicionais[i].Produto.Id + ')"/> ';
                    html += '                         <label class="form-check-label" for="flexCheckDefault"> ' + adicionais[i].Produto.NomeProduto + '  <span class="precoAdicional">R$ ' + adicionais[i].Valor.toFixed(2) + '</span></label> ';
                    html += '                     </div> ';
                }
                html += '                 </div> ';
                html += '             </div> ';
                html += '         </div> ';
            }
            html += '     </div> ';
            html += '     <div class="d-block text-center"> ';
            html += '         <button class="btnAdicionarPedido" onclick="adicionarPedido(' + result.Produto.id + ')">Adicionar ao Pedido (R$ <span id="valorProduto">' + result.Valor.toFixed(2) + '</span>)</button> ';
            html += '     </div> ';
            html += ' </div> ';

            $("#conteudoModal").html(html);
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}
