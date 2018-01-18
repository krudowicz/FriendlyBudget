﻿import * as React from 'react';
import { NavMenu } from './NavMenu';

export class Layout extends React.Component<{}, {}> {
    render() {
        return <div className='wrapper'>
            <NavMenu />
            { this.props.children }
        </div>
    }
}