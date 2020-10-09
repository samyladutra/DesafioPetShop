import React, { Component } from 'react';

export class Petshop extends React.Component {

    constructor(props) {
        super(props);

        this.state = { data: '', quantCaesPequenos: '', quantCaesGrandes: '' };
    }


    handleSubmit(event) {
        this.setState({
            data: event.data,
            quantCaesPequenos: event.quantCaesPequenos,
            quantCaesGrandes: event.quantCaesGrandes
        });
        event.preventDefault();
    }

    EncontrarMelhorPetshop() {
        Teste.GerenciamentoPetshop();
        Teste.EncontrarMelhorPetshop(this.state.data, this.state.quantCaesPequenos, this.state.quantCaesGrandes);
    }

    render() {
        return (
            <form onSubmit={this.handleSubmit}>

                <div>
                    <h1>Encontrar o melhor Petshop</h1>

                    <p>Informe a data e quantidade de caes pequenos e grandes para encontrar o melhor petshop</p>
                    <label>
                        Data:
                    <input type="text" value={this.state.data} />
                    </label>

                    <input type="submit" value="Encontrar" />
                </div>
            </form>
        );
    }
}
