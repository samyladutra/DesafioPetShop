import React, {Component} from 'react';
import './App.css';

interface EscolherPetshop {
  data: string,
  quantCaesPequenos: number,
  quantCaesGrandes: number
}

export default class App extends Component {
  constructor(props: EscolherPetshop){
    super(props);
    this.setState({
      data: props.data, 
      quantCaesPequenos: props.quantCaesPequenos, 
      quantCaesGrandes: props.quantCaesGrandes
    })
  }

  handleSubmit(e: any){
    e.preventDefault();
    
    
    //console.log(this.state)
    // console.log(this.state.quantCaesGrandes)
    // console.log(this.state.quantCaesPequenos)
  }

  // handleQuantCaesPequenos = (e) => {
  //   setState({quantCaesPequenos: e.target.value})
  // }

  // handleQuantCaesGrandes = () => {
  //   this.setState({quantCaesGrandes: this.state.quantCaesGrandes})
  // }

  render(){
    //console.log(this.state);
    return(
      <div className="uk-container">
      <h1>Encontrar o melhor Petshop</h1>

      <div>
        <form onSubmit={this.handleSubmit}>
            <div className="uk-margin uk-width-1-1">
                Data:
                <input type="text" name="data" id="data" placeholder="Data do pedido" className="uk-input"/>
                Informe a quantidade de cães pequenos:
                <input type="number" name="quantCaesPequenos" id="quantCaesPequenos" placeholder="Quantidade de cães pequenos" className="uk-input" onChange={() => this.setState({quantCaesPequenos: this.props.children?.valueOf})}/>
                Informe a quantidade de cães grandes:
                <input type="number" name="quantCaesGrandes" id="quantCaesGrandes" placeholder="Quantidade de cães grandes" className="uk-input" />
            </div>
            <div className="uk-width-1-1">
                <button type="submit" className="uk-button uk-button-primary">Encontrar</button>
            </div>
        </form>
        </div>
    </div>
    )
  }
}

