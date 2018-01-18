import * as React from 'react';
import { NavLink, Link } from 'react-router-dom';

export class NavMenu extends React.Component {
    render() {
        return <div className='navMenu'>
                <NavLink className='menuButton' exact to='/' activeClassName='active'>
                    Home
                </NavLink>
                <NavLink className='menuButton' to ='/families'>
                    Families
                </NavLink>
                <NavLink className='menuButton' to = '/settings'>
                    Settings
                </NavLink>
                <NavLink className='menuButton' id='logout-button' to='/user/login'>
                    Log in
                </NavLink>
                <NavLink className='menuButton' id='logout-button' to='/user/logout'>
                    Log out
                </NavLink>
        </div>
    }
}