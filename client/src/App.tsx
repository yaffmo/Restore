import { useEffect, useState } from "react";
import axios from "axios";
import { Product } from "./type";

function App() {
  const [products, setProduct] = useState<Product[]>([]);

  useEffect(() => {
    axios.get("https://localhost:7087/api/Product").then((res) => {
      const products = res.data;
      setProduct(products);
    });
  }, []);

  return (
    <div className="App">
      <ul>
        {products.map((item, index) => (
          <li key={index}>
            {item.id}-{item.name}
          </li>
        ))}
      </ul>
    </div>
  );
}

export default App;
