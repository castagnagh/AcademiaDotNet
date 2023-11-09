//inputs
let nomeInput = document.getElementById("nome");
let pessoaFisicaRadio = document.getElementById("pessoa_fisica");
let pessoaJuridicaRadio = document.getElementById("pessoa_juridica");
let cnpjInput = document.getElementById("cnpj");
let cpfInput = document.getElementById("cpf");
let dataNascimentoInput = document.getElementById("data_nascimento");
let enderecoInput = document.getElementById("endereco");
let cepInput = document.getElementById("cep");
let telefoneInput = document.getElementById("telefone");
let emailInput = document.getElementById("email");

//div
let juridicaCampos = document.getElementById("juridicaCampos")
let fisicaCampos = document.getElementById("fisicaCampos")

juridicaCampos.hidden = "true"
fisicaCampos.hidden = "true"

function pessoaSelecionada(){
    let pessoaFisicaRadio = document.getElementById("pessoa_fisica");
    let pessoaJuridicaRadio = document.getElementById("pessoa_juridica");
    if(pessoaFisicaRadio.checked == true){
        fisicaCampos.hidden = false
        juridicaCampos.hidden = true
        cnpjInput.value = null
    } else if(pessoaJuridicaRadio.checked === true){
        juridicaCampos.hidden = false
        fisicaCampos.hidden = true
        cpfInput.value = null
        dataNascimentoInput.value = null
    }
}

function mascaraCPF(){

    cpfInput.value = cpfInput.value.replace(/[^0-9]/g, '');

    if(cpfInput.value.length == 3 || cpfInput.value.length == 7){
        cpfInput.value += "."
    } else if (cpfInput.value.length == 11){
        cpfInput.value += "-"
    }
}

pessoaFisicaRadio.addEventListener("click", pessoaSelecionada)
pessoaJuridicaRadio.addEventListener("click", pessoaSelecionada)
cpfInput.addEventListener("keyup", mascaraCPF)