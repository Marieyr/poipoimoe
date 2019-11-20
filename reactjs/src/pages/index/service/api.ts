
import request from '../../../utils/request'

export function GetArticleList(params,data){
    return request({
        url:'/articles',
        method:'get',
        params,
        data
    })
}
