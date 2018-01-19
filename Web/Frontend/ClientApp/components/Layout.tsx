import * as React from 'react';
import { NavMenu } from './NavMenu';
import { Footer } from './Footer';

export class Layout extends React.Component<{}, {}> {
    render() {
        return <div className='wrapper'>
            <NavMenu />
            {this.props.children}
            <Footer />
        </div>
    }
}