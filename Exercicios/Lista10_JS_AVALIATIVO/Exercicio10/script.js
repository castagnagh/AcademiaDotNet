//form
let form = document.getElementById("form")

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

//span
let error = document.getElementsByClassName("error")

juridicaCampos.hidden = true
fisicaCampos.hidden = true

function pessoaSelecionada() {
    if (pessoaFisicaRadio.checked) {
        fisicaCampos.hidden = false;
        juridicaCampos.hidden = true;
        cnpjInput.value = "";
    } else if (pessoaJuridicaRadio.checked) {
        juridicaCampos.hidden = false;
        fisicaCampos.hidden = true;
        cpfInput.value = "";
        dataNascimentoInput.value = "";
    }
}

function mascaraCPF() {

    cpfInput.value = cpfInput.value.replace(/[A-Za-z]/g, "");

    if (cpfInput.value.length == 3 || cpfInput.value.length == 7) {
        cpfInput.value += "."
    } else if (cpfInput.value.length == 11) {
        cpfInput.value += "-"
    }
}

function mascaraCNPJ() {

    cnpjInput.value = cnpjInput.value.replace(/[A-Za-z]/g, "");

    if (cnpjInput.value.length == 2 || cnpjInput.value.length == 6) {
        cnpjInput.value += "."
    } else if (cnpjInput.value.length == 10) {
        cnpjInput.value += "/"
    } else if (cnpjInput.value.length == 15) {
        cnpjInput.value += "-"
    }
}

function mascaraCEP() {

    cepInput.value = cepInput.value.replace(/[A-Za-z]/g, "");

    if (cepInput.value.length == 5) {
        cepInput.value += "-"
    }
}

function mascaraTelefone() {

    telefoneInput.addEventListener("keyup", () => { telefoneInput.value = telefoneInput.value.replace(/[A-Za-z]/g, ""); })

    if (telefoneInput.value.length == 0) {
        telefoneInput.value += "("
    } else if (telefoneInput.value.length == 3) {
        telefoneInput.value += ")"
    } else if (telefoneInput.value.length == 9) {
        telefoneInput.value += "-"
    }
}

function validacaoCampos() {
    for (let i = 0; i < error.length; i++) {
        error[i].textContent = "";
    }

    if (nomeInput.value === "") {
        error[0].textContent = "O nome é obrigatório";
        return false;
    }

    if (!pessoaFisicaRadio.checked && !pessoaJuridicaRadio.checked) {
        error[1].textContent = "Selecione uma opção";
        return false;
    }

    if (pessoaFisicaRadio.checked) {
        if (cpfInput.value === "") {
            error[3].textContent = "O CPF é obrigatório";
            return false;
        }

        // Validação de Data de Nascimento
        const dataNascimento = new Date(dataNascimentoInput.value);
        if (isNaN(dataNascimento.getTime())) {
            error[4].textContent = "A data de nascimento é obrigatória ou inválida";
            return false;
        }
    }

    if (pessoaJuridicaRadio.checked) {
        if (cnpjInput.value === "") {
            error[2].textContent = "CNPJ é obrigatório";
            return false;
        }
    }

    // Validação de Endereço
    if (enderecoInput.value === "") {
        error[5].textContent = "O endereço é obrigatório";
        return false;
    }

    if (cepInput.value === "") {
        error[6].textContent = "O CEP é obrigatório";
        return false;
    }

    if (telefoneInput.value === "") {
        error[7].textContent = "O Telefone é obrigatório";
        return false;
    }

    if (emailInput.value === "") {
        error[8].textContent = "O Email é obrigatório";
        return false;
    }

    return true;
}


pessoaFisicaRadio.addEventListener("click", pessoaSelecionada)
pessoaJuridicaRadio.addEventListener("click", pessoaSelecionada)
cpfInput.addEventListener("keyup", mascaraCPF)
cnpjInput.addEventListener("keyup", mascaraCNPJ)
cepInput.addEventListener("keyup", mascaraCEP)
telefoneInput.addEventListener("keypress", mascaraTelefone)
form.onsubmit = validacaoCampos