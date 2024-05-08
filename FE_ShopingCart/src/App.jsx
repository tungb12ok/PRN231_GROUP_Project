import { useContext, useEffect, useMemo, useState } from 'react'
import reactLogo from './assets/react.svg'
import viteLogo from '/vite.svg'
import './App.css'
import { CheckboxGroup, Checkbox, Image, Divider, Button, Tooltip, Badge, Modal, ModalContent, ModalHeader, ModalBody, ModalFooter, useDisclosure, cn, Pagination } from "@nextui-org/react";
import ProductCard from './components/products/Card';
import { HiShoppingCart } from "react-icons/hi2";
import { CartContext, CartProvider, useCart } from './contexts/CartContext';

const SIZES = [
  'XS', 'S', 'M', 'L',
  'XL', 'XXL'
];

function App() {
  const [selected, setSelected] = useState([]);

  const [products, setProducts] = useState([]);

  const { isOpen, onOpen, onClose } = useDisclosure();


  const { cart } = useCart();

  const itemsPerPage = 6;
  const [currentPage, setCurrentPage] = useState(0);
  const [allProducts, setAllProducts] = useState([]);

  const openCartModal = () => {
    onOpen();
  }

  useEffect(() => {
    fetch('https://api.escuelajs.co/api/v1/products')
      .then(res => res.json())
      .then(json => {
        setAllProducts(json);

        setCurrentPage(1);
      });
  }, []);

  useEffect(() => {
    const startInd = currentPage * itemsPerPage - itemsPerPage;
    setProducts(allProducts.slice(startInd, startInd + itemsPerPage));
  }, [currentPage]);

  const totalPages = useMemo(() => Math.ceil(allProducts.length / itemsPerPage), [allProducts]);

  return (
    <div className="flex flex-col">
      <div className='flex justify-end m-4 mb-0'>
        <Tooltip content="Cart">
          <Badge content={cart.length} isInvisible={cart.length === 0} variant='flat' color='secondary'>
            <Button onClick={openCartModal} isIconOnly size='sm' color="secondary" variant="light">
              <HiShoppingCart size={25} />
            </Button>
          </Badge>
        </Tooltip>

        <Modal
          size='md'
          isOpen={isOpen}
          onClose={onClose}
          placement="center"
        >
          <ModalContent>
            {(onClose) => (
              <>
                <ModalHeader className="flex flex-col gap-1">Cart</ModalHeader>
                <ModalBody>
                  {
                    cart.map(product => {
                      return <Checkbox
                        key={product.id}
                        classNames={{
                          base: cn(
                            "inline-flex w-full max-w-md bg-content1",
                            "hover:bg-content2 items-center justify-start",
                            "cursor-pointer rounded-lg gap-2 p-4 border-2 border-transparent",
                          ),
                          label: "w-full",
                        }}
                      >
                        <div className="w-full flex flex-row items-center gap-2">
                          <Image
                            width={50}
                            src={product.images[0]}
                            radius='sm'
                          />

                          <p>{product.title}</p>
                        </div>
                      </Checkbox>;
                    })
                  }
                </ModalBody>
                <ModalFooter>
                  <Button color="primary" onPress={onClose}>
                    Checkout
                  </Button>
                </ModalFooter>
              </>
            )}
          </ModalContent>
        </Modal>
      </div>

      <div className='flex flex-col p-6 pt-2 gap-4 md:flex-row'>
        <div className="basis-1/4">
          <h3 className='flex justify-start'>Sizes: </h3>
          <div className="flex flex-col">
            <CheckboxGroup
              orientation='horizontal'
              selected={selected}
              onValueChange={setSelected}
            >
              {SIZES.map(size => <Checkbox key={size} value={size}>{size}</Checkbox>)}
            </CheckboxGroup>
          </div>
        </div>
        <div className="basis-3/4">
          <h3 className='flex justify-start'>{allProducts.length} Product(s) found</h3>
          <div className='flex flex-wrap gap-y-4 gap-x-2 justify-center'>
            {
              products.map(product => {
                return <ProductCard key={product.id} product={product} />;
              })
            }
          </div>
          <Pagination total={totalPages} initialPage={currentPage} page={currentPage} onChange={(page) => setCurrentPage(page)} />
        </div>
      </div>
    </div>
  )
}

export default App;
