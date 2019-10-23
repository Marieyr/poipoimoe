import React, { Component } from 'react';
import styles from './index.scss';

interface IState{
    isScroll:boolean
}

export default class index extends Component<{},IState> {
  constructor(props: {}) {
    super(props);
    this.state={
        isScroll:true
    }
  }

  componentDidMount() {
    //监听滚动隐藏导航事件
    window.addEventListener('scroll', this.handleScroll);
  }
  componentWillUnmount() {
    //卸载滚动吟唱导航事件
    window.removeEventListener('scroll', this.handleScroll);
  }
  //滚动隐藏导航使事件
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
