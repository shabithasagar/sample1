import { useState } from 'react'
import navbar from './Components/navbar'
import './App.css'
import { Route, Routes } from 'react-router-dom'
import Navbar from './Components/navbar'
import GetAuthorComponent from './Components/GetAuthorComponent'
import PostAuthorComponent from './Components/PostAuthorComponent'

const App = () => {
  const [count, setCount] = useState(0)

  return (
    <div>
      <Navbar/>
      <Routes>
        <Route path='/authors' element={<GetAuthorComponent/>}></Route>
        <Route path='/regauthors' element={<PostAuthorComponent/>}></Route>
      </Routes>
    </div>
  )
}

export default App
