import React, { Component } from 'react';
import styles from './index.scss';

interface IProps{
    isScroll:boolean
}

export default class index extends Component<{},IProps> {
  constructor(props: {}) {
    super(props);
    this.state={
        isScroll:true
    }
  }

  componentDidMount() {
    window.addEventListener('scroll', this.handleScroll);
  }
  componentWillUnmount() {
    window.removeEventListener('scroll', this.handleScroll);
  }

  handleScroll=(event: Event)=>{
    let scrollTop = document.documentElement.scrollTop;
    if (scrollTop === 0) {
       this.setState({
           isScroll:true
       })
    } else {
        this.setState({
            isScroll:false
        })
    }
  }

  render() {
    return (
      <div>
        <header className={`${styles['poi-header']} ${this.state.isScroll?'poi-display-hidden':'poi-display-show'} noselect `}>
          <div className={styles['poi-logo']} />
          <div className={styles['poi-nav']}>
            <ul>
              <li>首页</li>
              <li>首页</li>
              <li>首页</li>
              <li>首页</li>
              <li>首页</li>
            </ul>
          </div>
          <div className={styles['poi-other']} />
        </header>
      </div>
    );
  }
}
