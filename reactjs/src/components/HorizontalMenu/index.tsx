import React, { useState, useEffect } from 'react';
import styles from './index.scss';

export default () => {
  const [hidden, sethidden] = useState(false);

  useEffect(() => {
    window.addEventListener('scroll', handleScroll);

    return ()=>{
      window.removeEventListener('scroll', handleScroll);
    }
  }, []);

  let handleScroll = () => {
    let scrollTop = document.documentElement.scrollTop;
    if (scrollTop === 0) sethidden(true);
    else sethidden(false);
  };
  return (
    <div>
      <header
        className={`${styles['poi-header']} ${hidden ? 'poi-display-hidden' : 'poi-display-show'} noselect `}
      >
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
};
