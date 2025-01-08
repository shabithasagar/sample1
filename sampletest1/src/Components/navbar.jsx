
import React from 'react';
import { Link } from 'react-router-dom';
import { AppBar, Toolbar, Button } from '@mui/material';

const Navbar = () => {
  return (
    <AppBar position="static">
      <Toolbar>
        <Button color="inherit" component={Link} to='/authors'>
          Authors
        </Button>
        <Button color="inherit" component={Link} to="/regauthors">
          Register Authors
        </Button>
        <Button color="inherit" component={Link} to="/category">
          Category
        </Button>
        <Button color="inherit" component={Link} to="/regcategory">
        Register Category
        </Button>
        <Button color="inherit" component={Link} to="/logout">
          Logout
        </Button>
      </Toolbar>
    </AppBar>
  );
};

export default Navbar;
