import { Button, Divider, Image, Card, CardHeader, useDisclosure, ModalContent, ModalHeader, ModalBody, ModalFooter, Modal } from "@nextui-org/react";
import { useContext } from "react";
import { CartContext, useCart } from "../../contexts/CartContext";

export default function ProductCard({ product }) {
    const { cart, setCart } = useCart();

    const addToCart = () => {
        console.log('Add to cart: ' + product.title);
        const found = cart.find(each => each.id == product.id);
        if (!found) {
            setCart([...cart, product]);
        }
    }

    return <>
        <div className='flex flex-col gap-y-2 w-[300px] h-[450px]' key={product.id}>
            <Card>
                <CardHeader className="absolute p-0 z-10 flex-col items-end">
                    <p className="bg-black px-2 py-1 text-white font-medium text-sm rounded-sm shadow-sm">Free shipping</p>
                </CardHeader>
                <Image
                    isZoomed
                    className="z-0 object-cover w-auto h-[325px]"
                    alt={product.title}
                    src={"https://app.requestly.io/delay/300/" + product.images[1]}
                    radius='sm'
                    removeWrapper
                    loading="lazy"
                />
            </Card>
            <div className="flex flex-col justify-between h-[150px]">
                <h3 className="text-lg line-clamp-2">{product.title}</h3>
                <div>
                    <Divider className='w-12 bg-yellow-200 mx-auto'></Divider>
                    <div>
                        <span className='text-xl'>${product.price}</span>
                        <span className='font-light text-sm'>.00</span>
                    </div>
                    <Button color='primary' variant='flat' className='m-2 w-full' onClick={addToCart}>Add to cart</Button>
                </div>
            </div>
        </div>
    </>;
}