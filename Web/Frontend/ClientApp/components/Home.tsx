import * as React from 'react';
import { RouteComponentProps } from 'react-router-dom';

export default class Home extends React.Component<RouteComponentProps<{}>> {
    render() {
        return <div className='content-wrapper'>
            <div className='header'>
                <h1>Home</h1>
            </div>
            <div className='content'>
                <p>This is the home page</p>
            </div>
        </div>

    }
}