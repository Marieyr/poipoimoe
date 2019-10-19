import React from 'react';
import styles from './index.scss';

const BasicLayout: React.FC = props => {
  return (
    <div>
      <header className={`${styles['poi-header']}`}>
        <div className={styles['poi-logo']}></div>
        <div className={styles['poi-nav']}>
          <ul>
            <li>首页</li>
            <li>首页</li>
            <li>首页</li>
          </ul>
        </div>
        <div className={styles['poi-other']}></div>
      </header>
      {props.children}
      <footer className={styles['poi-footer']}></footer>
    </div>
  );
};

export default BasicLayout;
 

