export class CalculoCdbResponse {
    ResultadoBruto:number
    ResultadoLiquido:number

    constructor(ResultadoBruto: number, ResultadoLiquido: number) {
        this.ResultadoBruto = ResultadoBruto;
        this.ResultadoLiquido = ResultadoLiquido;
      }
  }