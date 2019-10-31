import React from 'react';

import styles from './index.scss';

/**
 * 文章模块
 */
export const ArticleBlock= ()=> {
  return (
    <article className={styles['poi-article']}>
      <header>
        <h2>标题</h2>
        <p>日期：2018-8-8 作者：作者 浏览量：0</p>
      </header>
      <div>内容</div>
    </article>
  );
}
/**
 * 附加模块
 */
export const SideBlock=()=> {

    return <article className={styles['poi-side']}>内容</article>;
  
}

export default ArticleBlock;
