import { useEffect, useState } from "react";
import axios from "axios";
import { Product } from "./type";
import Card from "@mui/material/Card";
import CardMedia from "@mui/material/CardMedia";
import CardHeader from "@mui/material/CardHeader";
import CardContent from "@mui/material/CardContent";
import Typography from "@mui/material/Typography";

function App() {
  const [products, setProduct] = useState<Product[]>([]);

  useEffect(() => {
    axios.get("http://localhost:5179/api/Product").then((res) => {
      const products = res.data;
      setProduct(products);
    });
  }, []);

  return (
    <div className="App">
      <ul>
        {products.map((item, index) => (
          <ul key={index}>
            <Card sx={{ maxWidth: 345, m: 5 }}>
              <CardMedia
                component="img"
                height="200"
                image={item.pictureUrl}
                alt={item.name}
              />
              <CardContent>
                <Typography gutterBottom variant="h5" component="div">
                  {item.name}
                </Typography>
                <Typography variant="body2" color="text.secondary">
                  {item.description}
                </Typography>
              </CardContent>
            </Card>
          </ul>
        ))}
      </ul>
    </div>
  );
}

export default App;
