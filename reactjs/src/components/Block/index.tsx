import React from 'react';

import styles from './index.scss';

import { ArticleModel } from '../../common/type';

/**
 * 文章模块
 */
export const ArticleBlock = (props: ArticleModel) => {
  return (
    <article className={styles['poi-article']}>
      <header>
        <h2>{props.title}</h2>
        <p>
          日期：{props.createDate} 作者：{props.author} 浏览量：{props.pageViews}
        </p>
      </header>
      <div>{props.content}</div>
    </article>
  );
};
/**
 * 附加模块
 */
export const SideBlock = () => {
  return <article className={styles['poi-side']}>内容</article>;
};

export default ArticleBlock;
