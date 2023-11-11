

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

    cpfInput.value = cpfInput.value.replace(/[A-Za-z]/g, "");

    if(cpfInput.value.length == 3 || cpfInput.value.length == 7){
        cpfInput.value += "."
    } else if (cpfInput.value.length == 11){
        cpfInput.value += "-"
    }
}

function mascaraCNPJ(){

    cnpjInput.value = cnpjInput.value.replace(/[A-Za-z]/g, "");

    if(cnpjInput.value.length == 2 || cnpjInput.value.length == 6){
        cnpjInput.value += "."
    } else if (cnpjInput.value.length == 10){
        cnpjInput.value += "/"
    } else if (cnpjInput.value.length == 15){
        cnpjInput.value += "-"
    }
}

function mascaraCEP(){

    cepInput.value = cepInput.value.replace(/[A-Za-z]/g, "");

    if(cepInput.value.length == 5){
        cepInput.value += "-"
    }
}

function mascaraTelefone(){

    telefoneInput.addEventListener("keyup", ()=> {telefoneInput.value = telefoneInput.value.replace(/[A-Za-z]/g, "");})

    if(telefoneInput.value.length == 0){
        telefoneInput.value += "("
    } else if (telefoneInput.value.length == 3){
        telefoneInput.value += ")"
    } else if (telefoneInput.value.length == 9){
        telefoneInput.value += "-"
    }
}

pessoaFisicaRadio.addEventListener("click", pessoaSelecionada)
pessoaJuridicaRadio.addEventListener("click", pessoaSelecionada)
cpfInput.addEventListener("keyup", mascaraCPF)
cnpjInput.addEventListener("keyup", mascaraCNPJ)
cepInput.addEventListener("keyup", mascaraCEP)
telefoneInput.addEventListener("keypress", mascaraTelefone)
