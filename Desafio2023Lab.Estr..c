#include <stdio.h>
#include <stdlib.h>
#include <string.h>

struct reg {
  char nome[20];
  char telefone[20];
  char email[20];
  char status;
};

int tamanho(FILE *);
void cadastrar(FILE *);
void consultar(FILE *);
void geraarqtxt(FILE *);
void excluir(FILE *);

int main() {
  int op;
  FILE *arq;

  if ((arq = fopen("dadoshotel.dat", "rb+")) == NULL) {
    if ((arq = fopen("dadoshotel.dat", "wb+")) == NULL) {
      printf("Falha ao abrir o arquivo!\n");
      return 1;
    }
  }

  do {
    printf("\n°°  Registros do Hotel Bays  °°\n\n");
    printf("1. Cadastrar hóspede\n");
    printf("2. Código da reserva\n");
    printf("3. Gerar registro de hóspedes\n");
    printf("4. Excluir registro\n");
    printf("5. Sair\n");
    printf("\n°°  Clientes Hospedados:%d  °°\n\n", tamanho(arq));
    printf("Opção:");
    if (scanf("%d", &op) != 1) {
      printf("Erro na leitura da opção!\n");
      clearerr(stdin);
      op = 0;
    }

    switch (op) {
    case 1:
      cadastrar(arq);
      break;
    case 2:
      consultar(arq);
      break;
    case 3:
      geraarqtxt(arq);
      break;
    case 4:
      excluir(arq);
      break;
    case 5:
      fclose(arq);
      break;
    default:
      printf("Opcao invalida!\n");
      break;
    }

  } while (op != 5);

  return 0;
}

void cadastrar(FILE *arq) {
  struct reg contato;
  char confirma;

  contato.status = ' ';

  printf("Cadastrando novo hóspede  :\n");
  printf("\nNúmero do código  :%d\n", tamanho(arq) + 1);
  printf("Nome  :");
  if (scanf("%19s", contato.nome) != 1) {
    printf("Erro!\n");
    clearerr(stdin);
    return;
  }
  printf("Telefone  :");
  if (scanf("%19s", contato.telefone) != 1) {
    printf("Erro!\n");
    clearerr(stdin);
    return;
  }
  printf("Email  :");
  if (scanf("%19s", contato.email) != 1) {
    printf("Erro!\n");
    clearerr(stdin);
    return;
  }
  printf("\nConfirma <s/n>:");
  if (scanf(" %c", &confirma) != 1) {
    printf("Erro!\n");
    clearerr(stdin);
    return;
  }

  if (confirma == 'S' || confirma == 's') {
    printf("\nConfirmado!\n\n\n");
    fseek(arq, 0, SEEK_END);
    fwrite(&contato, sizeof(struct reg), 1, arq);
  } else {
    printf("\nCancelado!\n");
  }

  system("pause");
}

void consultar(FILE *arq) {
  struct reg contato;
  int nr;

  printf("\nConsulta pelo codigo de reserva\n");
  printf("\nInforme o Codigo  :");
  if (scanf("%d", &nr) != 1) {
    printf("Erro na leitura do codigo!\n");
    clearerr(stdin);
    return;
  }

  if (nr > 0 && nr <= tamanho(arq)) {
    fseek(arq, (nr - 1) * sizeof(struct reg), SEEK_SET);
    fread(&contato, sizeof(struct reg), 1, arq);

    if (contato.status == ' ') {
      printf("\nNome  :%s", contato.nome);
      printf("\nTelefone  :%s", contato.telefone);
      printf("\nEmail  :%s\n\n", contato.email);
    } else {
      printf("\nRegistro excluido!\n");
    }
  } else {
    printf("\nNúmero de registro invalido!\n");
  }

  system("pause");
}

void geraarqtxt(FILE *arq) {
  char nomearq[20];
  printf("Nome do arquivo texto  :");
  if (scanf("%19s", nomearq) != 1) {
    printf("Erro na leitura do nome do arquivo!\n");
    clearerr(stdin);
    return;
  }
  strcat(nomearq, ".txt");
  FILE *arqtxt = fopen(nomearq, "w");

  if (!arqtxt) {
    printf("Não foi possivel criar esse arquivo!\n");
    system("pause");
    return;
  }

  fprintf(arqtxt,
          "Nome                Telefone    E-mail                   Status\n");
  fprintf(arqtxt, "------------------------------------------------------------\n");

  int nr;
  struct reg contato;

  for (nr = 0; nr < tamanho(arq); nr++) {
    fseek(arq, nr * sizeof(struct reg), SEEK_SET);
    fread(&contato, sizeof(struct reg), 1, arq);
    fprintf(arqtxt, "%-20s%-12s%-25s- %c\n", contato.nome, contato.telefone,
            contato.email, contato.status);
  }

  fprintf(arqtxt, "------------------------------------------------------------\n");
  fclose(arqtxt);
}

void excluir(FILE *arq) {
  struct reg contato;
  char confirma;
  int nr;

  printf("\nInforme o código de hóspede para excluir  : ");
  if (scanf("%d", &nr) != 1) {
    printf("Erro na leitura do codigo!\n");
    clearerr(stdin);
    return;
  }

  if (nr > 0 && nr <= tamanho(arq)) {
    fseek(arq, (nr - 1) * sizeof(struct reg), SEEK_SET);
    fread(&contato, sizeof(struct reg), 1, arq);

    if (contato.status == ' ') {
      printf("\nNome  :%s", contato.nome);
      printf("\nTelefone  :%s", contato.telefone);
      printf("\nEmail  :%s\n", contato.email);
      printf("\nConfirma a exclusao: <s/n>\n");
      if (scanf(" %c", &confirma) != 1) {
        printf("Erro na leitura da confirmacao!\n");
        clearerr(stdin);
        return;
      }

      if (confirma == 'S' || confirma == 's') {
        printf("\nExcluído\n\n");
        fseek(arq, (nr - 1) * sizeof(struct reg), SEEK_SET);
        contato.status = 'X';
        fwrite(&contato, sizeof(struct reg), 1, arq);
      } else {
        printf("\nExclusão cancelada.\n");
      }
    } else {
      printf("Registro inexistente!\n");
    }
  } else {
    printf("\nNúmero invalido!\n");
  }

  system("pause");
}

int tamanho(FILE *arq) {
  fseek(arq, 0, SEEK_END);
  return ftell(arq) / sizeof(struct reg);
}