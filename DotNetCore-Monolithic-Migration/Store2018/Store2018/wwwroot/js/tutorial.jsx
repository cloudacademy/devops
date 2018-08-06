class Product extends React.Component {
  render() {
    return (
      <div className="comment">
        <h2 className="commentAuthor">
          {this.props.sku}
        </h2>
        {this.props.children}
      </div>
    );
  }
}

class ProductList extends React.Component {
  render() {
    const productNodes = this.props.data.map(product => (
      <Product sku={product.sku} key={product.id}>
        {product.name}
      </Product>
    ));
    return (
      <div className="commentList">
        {productNodes}
      </div>
    );
  }
}

class CommentForm extends React.Component {
  render() {
    return (
      <div className="commentForm">
        Hello, world! I am a CommentForm.
      </div>
    );
  }
}

class CommentBox extends React.Component {
  constructor(props) {
    super(props);
    this.state = {data: []};
  }
  componentWillMount() {
    const xhr = new XMLHttpRequest();
    xhr.open('get', this.props.url, true);
    xhr.onload = () => {
      const data = JSON.parse(xhr.responseText);
      this.setState({ data: data });
    };
    xhr.send();
  }
  render() {
    return (
      <div className="commentBox">
        <h1>Comments</h1>
        <ProductList data={this.state.data} />
        <CommentForm />
      </div>
    );
  }
}

ReactDOM.render(
  <CommentBox url="https://localhost:5003/api/products" />,
  document.getElementById('content')
);
