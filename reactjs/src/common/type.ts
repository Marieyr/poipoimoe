
 export interface ArticleModel{
    title:string, //标题
    createDate:string,//创建时间
    updateDate:string,//修改时间
    pageViews:number,//浏览量
    content:string,//内容
    author:string//作者
}

export interface GlobalState{
    articles:Array<ArticleModel>;
}
