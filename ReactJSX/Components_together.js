1 component
class Example extends React.Component {
  render() {
    return <h1>Hello world</h1>;
  }
}

2 components
class OMG extends React.Component {
  render() {
    return <h1>Whooaa!</h1>;
  }
}

class Crazy extends React.Component {
  render() {
    return <OMG />;
  }
}
